using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
using System.Xml.Serialization;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CozmeticZone.Models
{
    [Serializable, XmlRoot("OnlineCosmeticsShop")]
    public class OnlineCosmeticShop
    {
        private static int Id;
        
        [XmlAttribute("shopId")]
        public int shopId;
        [XmlElement("Name")]
        public string Name;
        [XmlArray("Employees")]
        public Employee [] Employees;
        [XmlArray("Orders")]
        public Order [] Orders;
        [XmlArray("Contacts")]
        public Contact [] Contacts;

        static OnlineCosmeticShop()
        {
            var existingRecordsCount = DBManipulator.getRecordsCount("shops");
            Id = existingRecordsCount == -1 ? 1 : ++existingRecordsCount;
        }

        public OnlineCosmeticShop()
        {
            shopId = Id;
        }

        public OnlineCosmeticShop(string name)
        {
            if (!String.IsNullOrEmpty(name))
            {
                Name = name;
            }
        }
        
    }
}