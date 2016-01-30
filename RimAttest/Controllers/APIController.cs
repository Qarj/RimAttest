using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RimAttest.Models;
using RimAttest.ViewModels;

namespace RimAttest.Controllers
{
    public class APIController : ApiController
    {
        Search[] searches = new Search[]
        {
            new Search { SearchId = 1, RecipeName = "Tomato Soup", Cuisine = "English", MaxPrepTime = 15 },
            new Search { SearchId = 2, RecipeName = "Toast", Cuisine = "American", MaxPrepTime = 5},
            new Search { SearchId = 3, RecipeName = "Pesto", Cuisine = "Italian", MaxPrepTime = 22 }
        };

        public IEnumerable<Search> GetAllSearches()
        {
            return searches;
        }

        public IHttpActionResult GetSearch(int id)
        {
            var search = searches.FirstOrDefault((s) => s.SearchId == id);
            if (search == null)
            {
                return NotFound();
            }
            return Ok(search);
        }
    }
}
