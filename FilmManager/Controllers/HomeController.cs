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

        [HttpPost]
        public ActionResult Connected(User user)
        {
            using (Dal dal = new Dal())
            {
                List<User> users = dal.getUsers();
                if (user.login != null && user.password != null)
                {
                    foreach (User u in users)
                    {
                        if (user.login.Equals(u.login))
                        {
                            if (user.password.Equals(u.password))
                            {
                                Session["login"] = u.login;
                                Session["admin"] = u.admin;
                                Session["panier"] = new List<Film>();
                                return View("../Site/ListFilms", dal.getFilms());
                            }
                        }
                    }
                }

                Response.Redirect("/");
                return View("Index");
            }
        }

        public ActionResult Index()
        {
            return View();
        }

    }
}
