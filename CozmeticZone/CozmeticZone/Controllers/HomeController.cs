using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;
using Microsoft.AspNetCore.Mvc;
using CozmeticZone.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Metadata;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;

namespace CozmeticZone.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Serialize()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(OnlineCosmeticShop));

            var filesInfo = new Dictionary<string, bool>();

            for (int index = 1; index <= 20; index++)
            {
                try
                {
                    string fileName = $"Products_{index}.xml";
                    bool validXML = XMLValidator.isValidXML(fileName);

                    bool isValid = XMLValidator.isValidXML();

                    FileStream fileStream = new FileStream(
                        $"C:\\Users\\ksimeonova\\Documents\\ASP\\CozmeticZone\\CozmeticZone\\XML\\Products_{index}.xml",
                        FileMode.Open);

                    if (validXML)
                    {
                        OnlineCosmeticShop onlineCosmeticShop =
                            (OnlineCosmeticShop) xmlSerializer.Deserialize(fileStream);
                        var success = DBManipulator.fillDatabase(onlineCosmeticShop);
                        ViewBag.Sucess = success;
                    }

                    fileStream.Close();
                    filesInfo.Add(fileName, validXML);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    ViewBag.IncorrectFormat = true;
                }
            }

            ViewBag.FilesInfo = filesInfo;

            return View();
        }
    }
}