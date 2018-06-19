using System;
using System.IO;
using System.Xml.Serialization;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class CatalogController : Controller
    {
        //dependency injection ? 
//        XmlSerializer serializer;
        // GET
        public IActionResult Current()
        {
            return View("CurrentCampaign");
        }

        public IActionResult Add()
        {
            var start = new DateTime(2018, 06, 01);
            var end = new DateTime(2018, 06, 20);
            var model = new Catalog("First", start, end);

            //TODO: create a service to do this kind of serialization 
//            Stream stream = new FileStream();            
            
            var serializer = new XmlSerializer(typeof(Catalog));
            
            var fileStream = new StreamWriter("new_catalog.xml");
            
            serializer.Serialize(fileStream, model);
            
            fileStream.Close();
            
            return View("CurrentCampaign");
            
        }
    }
}