using RimAttest.Models;
using RimAttest.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace RimAttest.Controllers
{
    public class BulkUploadController : Controller
    {

        // GET: BulkUpload
        public ActionResult Index()
        {
            return View(new FileUploadViewModel());
        }

        public ActionResult Upload(FileUploadViewModel model)
        {
            List<Search> searches = GetSearches(model);
            //SearchBusinessLayer bal = new SearchBusinessLayer();
            //bal.UploadSearches(searches);
            return RedirectToAction("Confirmation", "BulkUpload");
        }

        private List<Search> GetSearches(FileUploadViewModel model)
        {
            List<Search> searches = new List<Search>();
            StreamReader csvreader = new StreamReader(model.fileUpload.InputStream);
            csvreader.ReadLine(); // Assuming first line is header
            while (!csvreader.EndOfStream)
            {
                var line = csvreader.ReadLine();
                var values = line.Split(',');//Values are comma separated
                Search s = new Search();
                s.RecipeName = values[0];
                s.Cuisine = values[1];
                s.MaxPrepTime = int.Parse(values[2]);
                searches.Add(s);
            }
            return searches;
        }

        public ActionResult Confirmation()
        {
            ViewBag.Message = "You have uploaded a file.";

            return View();
        }

        [HttpPost]
        public ActionResult XML(FileUploadViewModel model)
        {

            return RedirectToAction("Confirmation", "BulkUpload");


        }
    }
}