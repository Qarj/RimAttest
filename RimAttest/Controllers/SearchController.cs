using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RimAttest.Models;
using RimAttest.ViewModels;

namespace RimAttest.Controllers
{
    public class SearchController : Controller
    {
        public string GetString()
        {
            return "Hello World !!";
        }

        [NonAction]
        public string SimpleMethod()
        {
            return "This is not an action method";
        }

        public ActionResult SearchForm()
        {
            SearchViewModel vm = new SearchViewModel();
            return View("SearchForm", vm);
         }


        //[ValidateAntiForgeryToken]
        public ActionResult SearchRecipes(Search s, string BtnSubmit)
        {
            switch (BtnSubmit)
            {
                case "Search Recipes":
                    if (ModelState.IsValid)
                    {
                        return View("SearchConfirmation");
                    }
                    else
                    {
                        SearchViewModel vm = new SearchViewModel();
                        vm.RecipeName = s.RecipeName;
                        vm.Cuisine = s.Cuisine;
                        if (s.MaxPrepTime > 0)
                        {
                            vm.MaxPrepTime = s.MaxPrepTime.ToString();
                        }
                        else
                        {
                            vm.MaxPrepTime = ModelState["MaxPrepTime"].Value.AttemptedValue;
                        }
                        return View("SearchForm", vm);
                    }
                case "Cancel":
                    return RedirectToAction("SearchForm");
            }
            return new EmptyResult();

        }

    }



}