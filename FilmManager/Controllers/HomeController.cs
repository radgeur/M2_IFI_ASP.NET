using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FilmManager.Models;

namespace FilmManager.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        //private Dal dal = new Dal();

        [HttpPost]
        public ActionResult Connect(User u)
        {
            //List<User> users = dal.getUsers();
            if(u.login.Equals("toto")) 
                return View("../Site/ListFilms");
            else
                return View("Index");
        }

        public ActionResult Index()
        {
            return View("Index");
        }

    }
}
