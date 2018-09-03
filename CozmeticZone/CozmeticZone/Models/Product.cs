using System;
using System.Data;
using System.Xml.Serialization;
using Microsoft.EntityFrameworkCore.Update;

namespace CozmeticZone.Models
{
    public class Product
    {
        private static int ProdOrdId;
        private static int Id;
        
        [XmlAttribute("productOrderId")]
        public int ProductOrderId;
        [XmlAttribute("productId")]
        public int ProductId;
        [XmlAttribute("count")]
        public int Count;
        [XmlAttribute("customerName")]
        public string CustomerName;
        [XmlElement("Code")]
        public int Code;
        [XmlElement("Category")]
        public string Category;
        [XmlElement("Description")]
        public string Description;
        [XmlElement("Price")]
        public float Price;

        static Product()
        {
            var existingRecordsCount1 = DBManipulator.getRecordsCount("products");
            var existingRecordsCount2 = DBManipulator.getRecordsCount("orders_products");

            Id = existingRecordsCount1 == -1 ? 1 : ++existingRecordsCount1;
            ProdOrdId = existingRecordsCount2 == -1 ? 1 : ++existingRecordsCount2;

        }

        public Product()
        {
            
        }
        
        public Product(int count, string customerName, int code, string category, string description, float price)
        {
            if (count > 0 && count <= 100)
            {
                Count = count;
            }

            if (!String.IsNullOrEmpty(customerName))
            {
                CustomerName = customerName;
            }

            if (code > 1000 && code < 20000)
            {
                Code = code;
            }

            if (!String.IsNullOrEmpty(category))
            {
                Category = category;
            }

            if (!String.IsNullOrEmpty(description))
            {
                Description = description;
            }

            if (price > 0 && price <= 200)
            {
                Price = price;
            }
        }
    }
}