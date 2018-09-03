using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;
using System.Xml.Serialization;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.IdentityModel.Tokens;

namespace CozmeticZone.Models
{
    public class Address
    {
        [XmlElement] 
        public string Country;
        [XmlElement("City")] public string City;
        [XmlElement("Street")] public string Street;
        [XmlElement("Number")] public int Number;

        public Address()
        {
        }

        public Address(string country, string city, string street, int number)
        {
            if (!String.IsNullOrEmpty(country))
            {
                Country = country;
            }

            if (!String.IsNullOrEmpty(city))
            {
                City = city;
            }

            if (!String.IsNullOrEmpty(city))
            {
                Street = street;
            }

            if (number > 0 && number < 300)
            {
                Number = number;
            }
        }
    }
}