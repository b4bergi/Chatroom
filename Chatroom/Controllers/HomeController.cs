using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChatroomDB;
using Microsoft.Extensions.Logging;

namespace Chatroom.Controllers
{
    public class HomeController : Controller
    {
        ChatContext db = new ChatContext();
        ILogger<HomeController> logger;
        public HomeController(ChatContext db,ILogger<HomeController> logger) 
        {
            this.db = db;
            this.logger = logger;
        }
        public IActionResult Index()
        {
            seedDB();
            logger.LogWarning(db.Chatrooms.Count().ToString());
            return View();
        }

        private void seedDB()
        {
            throw new NotImplementedException();
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

        public IActionResult Error()
        {
            return View();
        }
    }
}
