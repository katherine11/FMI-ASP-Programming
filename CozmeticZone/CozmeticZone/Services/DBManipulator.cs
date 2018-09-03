using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Transactions;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using Microsoft.IdentityModel.Protocols;

namespace CozmeticZone.Models
{
    public class DBManipulator : DbContext
    {
        public static int getRecordsCount(string tableName)
        {
            int rowsCount = 0;

            using (SqlConnection sqlConnection =
                new SqlConnection("Server=localhost;Database=onlineshop;Trusted_Connection=True"))
            {
                sqlConnection.Open();

                string queryString = $"SELECT count(*) FROM {tableName}";

                using (SqlCommand sqlCommand = new SqlCommand(queryString))
                {
                    sqlCommand.Connection = sqlConnection;
                    rowsCount = sqlCommand.ExecuteNonQuery();
                }
            }

            return rowsCount;
        }

        public static bool fillDatabase(OnlineCosmeticShop onlineCosmeticShop)
        {
            try
            {
                using (SqlConnection sqlConnection =
                    new SqlConnection("Server=localhost;Database=onlineshop;Trusted_Connection=True"))
                {
                    sqlConnection.Open();

                    using (SqlCommand sqlCommand =
                        new SqlCommand(getQueryString(onlineCosmeticShop.shopId, onlineCosmeticShop.Name)))
                    {
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.ExecuteNonQuery();
                    }

                    foreach (var employee in onlineCosmeticShop.Employees)
                    {
                        using (SqlCommand sqlCommand = new SqlCommand(getQueryString(employee)))
                        {
                            sqlCommand.Connection = sqlConnection;
                            sqlCommand.ExecuteNonQuery();
                        }
                    }

                    foreach (var order in onlineCosmeticShop.Orders)
                    {
                        using (SqlCommand sqlCommand =
                            new SqlCommand(getQueryString(order)))
                        {
                            sqlCommand.Connection = sqlConnection;
                            sqlCommand.ExecuteNonQuery();
                        }

                        foreach (var product in order.Products)
                        {
                            using (SqlCommand sqlCommand2 = new SqlCommand(getQueryString(product)))
                            {
                                sqlCommand2.Connection = sqlConnection;
                                sqlCommand2.ExecuteNonQuery();
                            }

                            using (SqlCommand sqlCommand1 = new SqlCommand(getQueryString(order.OrderId, product)))
                            {
                                sqlCommand1.Connection = sqlConnection;
                                sqlCommand1.ExecuteNonQuery();
                            }
                        }
                    }

                    foreach (var contact in onlineCosmeticShop.Contacts)
                    {
                        using (SqlCommand sqlCommand = new SqlCommand(getQueryString(contact)))
                        {
                            sqlCommand.Connection = sqlConnection;
                            sqlCommand.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                return false;
            }

            return true;
        }

        private static string getQueryString(int id, string name)
        {
            return $"INSERT INTO shops(shop_id, name) VALUES ('{id}', N'{name}')";
        }

        private static string getQueryString(Employee employee)
        {
            string address = employee.Address.Country + ", " + employee.Address.City + ", " +
                             employee.Address.Street + ", " + employee.Address.Number;

            return $"INSERT INTO employees(employee_id, address, name, gender, age, position, salary, email, phone)" +
                   $"VALUES({employee.EmployeeId}, N'{address}', N'{employee.Name}', N'{employee.Gender}', {employee.Age}, " +
                   $"N'{employee.Position}', {employee.Salary}, N'{employee.Email}', N'{employee.Phone}')";
        }

        private static string getQueryString(Order order)
        {
            return $"INSERT INTO orders(order_id, employee_id, total_price) VALUES({order.OrderId}, " +
                   $"{order.EmployeeId}, {order.TotalPrice})";
        }

        private static string getQueryString(Product product)
        {
            return $"INSERT INTO products(product_id, code, category, description, price) " +
                   $"VALUES({product.ProductId}, {product.Code} , N'{product.Category}', N'{product.Description}', " +
                   $"{product.Price})";
        }

        private static string getQueryString(int orderId, Product product)
        {
            return
                $"INSERT INTO orders_products(product_order_id, product_id, order_id, product_count, customer_name) " +
                $"VALUES ({product.ProductOrderId}, {product.ProductId}, {orderId}, {product.Count}, " +
                $"N'{product.CustomerName}')";
        }

        private static string getQueryString(Contact contact)
        {
            return $"INSERT INTO contacts(contact_id, email, phone, fax) " +
                   $"VALUES ({contact.ContactId}, N'{contact.Email}', N'{contact.Phone}', N'{contact.Fax}')";
        }
    }
}