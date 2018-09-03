using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Xml;
using System.Xml.Serialization;
using CozmeticZone.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json;

namespace CozmeticZone.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save()
        {
            var formData = this.Request.Form;

            try
            {
                OnlineCosmeticShop onlineCosmeticShop = ObjectConstuctor.constructXMLObject(formData);

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(OnlineCosmeticShop));

                FileStream fileStream = new FileStream(
                    $"C:\\Users\\ksimeonova\\Documents\\ASP\\CozmeticZone\\CozmeticZone\\XML\\G_Products.xml",
                    FileMode.CreateNew);

                using (StreamWriter streamWriter = new StreamWriter(fileStream))
                {
                    xmlSerializer.Serialize(streamWriter, onlineCosmeticShop);
                }

                string name = "G_Products.xml";
                bool isValidXML = XMLValidator.isValidXML(name);

                if (isValidXML)
                {
                    DBManipulator.fillDatabase(onlineCosmeticShop);
                }

                ViewBag.ValidXML = isValidXML;
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
                ViewBag.FileExists = true;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e);
                ViewBag.IncorrectFormat = true;
            }

            return View("Save");
        }
    }
}