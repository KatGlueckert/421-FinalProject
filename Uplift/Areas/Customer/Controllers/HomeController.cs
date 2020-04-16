using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Uplift.DataAccess.Data;
using Uplift.Models;

namespace Uplift.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        
        public IActionResult Index()
        {
            List<Item> myItems = new List<Item>();
            var displayItem = new Item();
            displayItem.Title = "Title1";
            displayItem.Price = 89.99;
            displayItem.ItemDescription = "This is the item description";
            myItems.Add(displayItem);

            displayItem = new Item();
            displayItem.Title = "Title2";
            displayItem.Price = 79.99;
            displayItem.ItemDescription = "This is the item description2. This is the item description";
            myItems.Add(displayItem);

            displayItem = new Item();
            displayItem.Title = "Title3";
            displayItem.Price = 69.99;
            displayItem.ItemDescription = "This is the item description3. This is the item description. This is the item description";
            myItems.Add(displayItem);

            displayItem = new Item();
            displayItem.Title = "Title4";
            displayItem.Price = 59.99;
            displayItem.ItemDescription = "This is the item description4. This is the item description. This is the item description";
            myItems.Add(displayItem);

            displayItem = new Item();
            displayItem.Title = "Title5";
            displayItem.Price = 49.99;
            displayItem.ItemDescription = "This is the item description5. This is the item description. This is the item description. ";
            myItems.Add(displayItem);

            displayItem = new Item();
            displayItem.Title = "Title6";
            displayItem.Price = 39.99;
            displayItem.ItemDescription = "This is the item description6. This is the item description. This is the item description. This is the item description";
            myItems.Add(displayItem);

            displayItem = new Item();
            displayItem.Title = "Title7";
            displayItem.Price = 29.99;
            displayItem.ItemDescription = "This is the item description7. This is the item description. This is the item description. This is the item description. This is the item description. This is the item description. ";
            myItems.Add(displayItem);

            displayItem = new Item();
            displayItem.Title = "Title8";
            displayItem.Price = 19.99;
            displayItem.ItemDescription = "This is the item description8. This is the item description. This is the item description. This is the item description. This is the item description. This is the item description. This is the item description. This is the item description. ";
            myItems.Add(displayItem);

            displayItem = new Item();
            displayItem.Title = "Title9";
            displayItem.Price = 9.99;
            displayItem.ItemDescription = "This is the item description9";
            myItems.Add(displayItem);

            return View(myItems);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
