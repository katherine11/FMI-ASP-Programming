using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Rewrite.Internal.PatternSegments;
using SampleTestProject.Models;

namespace SampleTestProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult Serialize()
        {

            //TODO: loop through the list of all XML files and do the same:
            
            //deserialize
            XmlSerializer serializer = new XmlSerializer(typeof(Sample));
            
            FileStream fileStream = new FileStream("/home/ksimeonova/Documents/fmi/3.2/asp/SampleTestProject/SampleTestProject/XML/Samples.xml", FileMode.Open);
            
//            validate:
            bool validXML = isValidXML();

            Sample sample = (Sample) serializer.Deserialize(fileStream); 
            
            //insert the newly created object to the db:
            insertToDB(sample);
            
            ViewBag.ValidXML = validXML;
//            TODO: get the real name of the xml
            ViewBag.XMLFileName = "Test name";
            
            return View();
        }

        private bool isValidXML()
        {
            //validate according to the schema or dtd:
            
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ValidationType = ValidationType.Schema;
//            settings.Schemas.Add("",
//                "/home/ksimeonova/Documents/fmi/3.2/asp/SampleTestProject/SampleTestProject/XML/Samples.xsd");
            
            //TODO: make it work with the generated schema:
            
            settings.ValidationFlags |= XmlSchemaValidationFlags.ProcessInlineSchema;
            settings.ValidationFlags |= XmlSchemaValidationFlags.ProcessSchemaLocation;
            settings.ValidationFlags |= XmlSchemaValidationFlags.ReportValidationWarnings;
            settings.ValidationEventHandler += new ValidationEventHandler(sampleSettingsValidationEventHandler);

            XmlReader reader = XmlReader.Create("/home/ksimeonova/Documents/fmi/3.2/asp/SampleTestProject/SampleTestProject/XML/Samples.xml", settings);

            while (reader.Read())
            {
                return true;
            }
            
            return false;
        }

        static void sampleSettingsValidationEventHandler(object sender, ValidationEventArgs args)
        {
            if (args.Severity == XmlSeverityType.Warning)
            {
                Console.Write("WARNING: ");
                Console.WriteLine(args.Message);
            }
            else if (args.Severity == XmlSeverityType.Error)
            {
                Console.Write("ERROR: ");
                Console.WriteLine(args.Message);
            }
        }

        private void serializeXML(string xmlFile)
        {
            
            //create object
            //create filestream
            //serialize it
            //save the file in .xml

        }

        private void deserializeXML()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Sample));
            
            FileStream fileStream = new FileStream("/home/ksimeonova/Documents/fmi/3.2/asp/SampleTestProject/SampleTestProject/XML/Samples.xml", FileMode.Open);

            Sample sample = (Sample) serializer.Deserialize(fileStream);
        }

        private void insertToDB(Sample sample)
        {
            //save the object

            using (var dbContext = new SampleContext())
            {
                dbContext.Samples.Add(sample);
                dbContext.SaveChanges();
            }
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}