using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace CozmeticZone.Models
{
    public class Contact
    {
        private static int Id;
        
        [XmlAttribute("contactId")]
        public int ContactId;
        [XmlElement("Email")]
        public string Email;
        [XmlElement("Phone")]
        public string Phone;
        [XmlElement("Fax")]
        public int Fax;

        static Contact()
        {
            var existingRecordsCount = DBManipulator.getRecordsCount("contacts");
            Id = existingRecordsCount == -1 ? 1 : ++existingRecordsCount;
        }

        public Contact()
        {
            ContactId = Id;
        }

        public Contact(string email, string phone, int fax)
        {
            ContactId = Id;
            if (!String.IsNullOrEmpty(email))
            {
                Email = email;
            }

            if (!String.IsNullOrEmpty(phone))
            {
                Phone = phone;
            }

            if (fax > 0 && fax < 1000000)
            {
                Fax = fax;
            }
        }
    }
}