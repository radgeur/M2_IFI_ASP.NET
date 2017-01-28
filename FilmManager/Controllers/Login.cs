using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FilmManager.Models;
using System.Data.Entity;

namespace FilmManager.Controllers
{
    public class Login : Controller
    {
        //
        // GET: /Login/

        public ActionResult Index()
        {
            return View("Site.ListFilms");
        }

    }
}
