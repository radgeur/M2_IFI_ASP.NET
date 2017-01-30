using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FilmManager.Models;

namespace FilmManager.Controllers
{
    public class ListFilmsController : Controller
    {
        Dal dal = new Dal();
        //
        // GET: /ListFilms/
        public ActionResult Selected(long id)
        {
            Film f = dal.getFilm(id);
            List<Film> films = (List<Film>)Session["panier"];
            if(!films.Contains(f))
                films.Add(f);
            Session["panier"] = films;
            return View("../Site/ListFilms", dal.getFilms());
        }

        public ActionResult DeleteFilm(long id)
        {
            if(Session["admin"].Equals(true))
                dal.deleteFilm(id);
            return View("../Site/ListFilms", dal.getFilms());
        }

        public ActionResult Disconnected()
        {
            Session.RemoveAll();
            Response.Redirect("/");
            return View("Index");
        }

        public ActionResult Saw(long id)
        {
            //dal.AddFilmSaw((String)Session["login"], id);
            return View("../Site/ListFilms", dal.getFilms());
        }

        public ActionResult Index()
        {
            return View();
        }

    }
}
