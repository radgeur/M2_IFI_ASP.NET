using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FilmManager.Models;

namespace FilmManager.Controllers
{
    public class PanierController : Controller
    {
        Dal dal = new Dal();
        //
        // GET: /Panier/
        public ActionResult Return()
        {
            return View("../Site/ListFilms", dal.getFilms());
        }

        public ActionResult Delete(long id)
        {
            Film f = dal.getFilm(id);
            List<Film> films = (List<Film>)Session["panier"];
            films.Remove(f);
            Session["panier"] = films;
            ViewData["films"] = Session["panier"];
            return View("../Site/Panier");
        }

        public ActionResult Index()
        {
            ViewData["films"] = Session["panier"];
            return View("../Site/Panier");
        }

    }
}
