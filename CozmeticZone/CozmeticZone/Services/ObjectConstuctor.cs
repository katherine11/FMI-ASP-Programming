using System;
using System.Globalization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Razor.Language.CodeGeneration;

namespace CozmeticZone.Models
{
    public class ObjectConstuctor
    {
        public static OnlineCosmeticShop constructXMLObject(IFormCollection formData)
        {
            OnlineCosmeticShop onlineCosmeticShop = new OnlineCosmeticShop();

            onlineCosmeticShop.Name = formData["name"];

            onlineCosmeticShop.Employees = new Employee[1];

            Address address = new Address(formData["country"], formData["city"],
                formData["street"], Int16.Parse(formData["number"]));

            Employee employee = new Employee(formData["gender"], formData["employeeName"], address,
                Int16.Parse(formData["age"]), formData["position"],
                float.Parse(formData["salary"], CultureInfo.InvariantCulture.NumberFormat),
                formData["employeeEmail"], formData["employeePhone"]);

            onlineCosmeticShop.Employees[0] = employee;

//            TODO: implement functionality for adding more than one object: 
            onlineCosmeticShop.Orders = new Order[1];

            Order order = new Order();
            onlineCosmeticShop.Orders[0] = order;

            Product product = new Product(Int16.Parse(formData["count"]),
                formData["customerName"], Int16.Parse(formData["code"]),
                formData["category"], formData["description"], float.Parse(formData["price"]));

            onlineCosmeticShop.Orders[0].Products = new Product[1];
            onlineCosmeticShop.Orders[0].Products[0] = product;

            onlineCosmeticShop.Contacts = new Contact[1];
            Contact contact = new Contact(formData["email"], formData["phone"], Int32.Parse(formData["fax"]));

            onlineCosmeticShop.Contacts[0] = contact;

            return onlineCosmeticShop;
        }
    }
}