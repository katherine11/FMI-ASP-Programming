using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CozmeticZone.Models
{
    public class Employee
    {
        private static int Id;
        [XmlAttribute("gender")]
        public string Gender;
        [XmlAttribute("employeeId")]
        public int EmployeeId;
        [XmlElement("EmployeeName")]
        public string Name;
        [XmlElement("Address")]
        public Address Address;
        [XmlElement("Age")]
        public int Age;
        [XmlElement("Position")]
        public string Position;
        [XmlElement("Salary")]
        public float Salary;
        [XmlElement("Email")]
        public string Email;
        [XmlElement("Telephone")]
        public string Phone;

        static Employee()
        {
            var existingRecordsCount = DBManipulator.getRecordsCount("employees");
            Id = existingRecordsCount == -1 ? 1 : ++existingRecordsCount;
        }

        public Employee()
        {
            
        }

        public Employee(string gender, string name, Address address, int age, string position, float salary, string email, string phone)
        {
            EmployeeId = Id;
            
            if (!String.IsNullOrEmpty(gender))
            {
                Gender = gender;
            }

            if (!String.IsNullOrEmpty(name))
            {
                Name = name;
            }
            
            Address = address;

            if (age >= 16 && age <= 65)
            {
                Age = age;
            }

            if (!String.IsNullOrEmpty(name))
            {
                Position = position;
            }

            if (salary >= 400 && salary <= 5000)
            {
                Salary = salary;
            }

            if (!String.IsNullOrEmpty(email))
            {
                Email = email;
            }

            if (!String.IsNullOrEmpty(phone))
            {
                Phone = phone;
            }
        }
    }
}