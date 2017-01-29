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
        //Session["login"] = null;

        [HttpPost]
        public ActionResult Connect(User user)
        {
            using (Dal dal = new Dal())
            {
                List<User> users = dal.getUsers();
                foreach (User u in users)
                {
                    if (user.login.Equals(u.login))
                    {
                        if (user.password.Equals(u.password))
                            return View("../Site/ListFilms");
                    }
                }

                return View("/");
            }
        }

        public ActionResult Index()
        {
            return View();
        }

    }
}
