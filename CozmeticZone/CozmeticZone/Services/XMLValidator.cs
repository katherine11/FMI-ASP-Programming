using System;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

namespace CozmeticZone.Models
{
    public class XMLValidator
    {
        
        public static bool isValidXML()
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ValidationType = ValidationType.Schema;

            bool isValid;
            settings.Schemas.Add("",
                "C:\\Users\\ksimeonova\\Documents\\ASP\\CozmeticZone\\CozmeticZone\\XML\\ProductsSchema.xsd");

            try
            {
                using (XmlReader reader =
                    XmlReader.Create(
                        "C:\\Users\\ksimeonova\\Documents\\ASP\\CozmeticZone\\CozmeticZone\\XML\\Products_2.xml",
                        settings))
                {
                    while (reader.Read())
                    {
                        
                    }

                    isValid = true;
                }
            }
            catch (Exception e)
            {
                isValid = false;
            }

            return isValid;
        }

        public static bool isValidXML(string fileName)
        {
            
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ValidationType = ValidationType.Schema;

            bool isValid;
            settings.Schemas.Add("",
                "C:\\Users\\ksimeonova\\Documents\\ASP\\CozmeticZone\\CozmeticZone\\XML\\ProductsSchema.xsd");

            try
            {
                using (XmlReader reader = XmlReader.Create($"C:\\Users\\ksimeonova\\Documents\\ASP\\CozmeticZone\\CozmeticZone\\XML\\{fileName}", settings))
                {
                    while (reader.Read())
                    {
                        
                    }

                    isValid = true;
                }
            }
            catch (Exception e)
            {
                isValid = false;
            }

            return isValid;
            
        }
        
        
//        bool isValidXMLSecond()
//        {
//            string xsdName = "C:\\Users\\ksimeonova\\Documents\\ASP\\CozmeticZone\\CozmeticZone\\XML\\ProductsSchema.xsd";
//            string xmlName = "C:\\Users\\ksimeonova\\Documents\\ASP\\CozmeticZone\\CozmeticZone\\XML\\Products_2.xml";
//
//            XmlSchemaSet schemas = new XmlSchemaSet();
//            schemas.Add("", xsdName);
//
//            XDocument custOrdDoc = XDocument.Load(xmlName);
//
//            bool isValid = true;
//
//            custOrdDoc.Validate(schemas, (o, e) =>
//                {
//                      isValid = false;
//                }
//            );
//
//            return isValid; 
//        }

    }
}