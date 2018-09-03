using System.Collections.Generic;
using System.Xml.Serialization;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CozmeticZone.Models
{
    public class Order
    {
        private static int emplId;
        private static int ordId;

        [XmlAttribute("employeeId")]
        public int EmployeeId = emplId;
        
        [XmlAttribute("orderId")]
        public int OrderId = ordId;
        
        [XmlAttribute("limitPrice")]
        public int LimitPrice;
        
        [XmlArray("Products")]
        public Product [] Products;
        
        [XmlElement("TotalPrice")]
        public float TotalPrice;

        static Order()
        {
            var existingRecordsCount1 = DBManipulator.getRecordsCount("orders");
            var existingRecordsCount2 = DBManipulator.getRecordsCount("employees");

            ordId = existingRecordsCount1 == -1 ? 1 : ++existingRecordsCount1;
            emplId = existingRecordsCount2 == -1 ? 1 : existingRecordsCount2;

        }

    }
}