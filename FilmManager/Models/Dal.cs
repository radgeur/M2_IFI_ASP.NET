using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FilmManager.Models
{
    public class Dal : IDal
    {
        private BddContext bdd;

        public Dal()
        {
            bdd = new BddContext();
        }

        public User getUser(String user)
        {
            return bdd.users.Find(user);
        }

        public List<User> getUsers()
        {
            return bdd.users.ToList();
        }

        public List<Film> getFilms()
        {
            return bdd.films.ToList();
        }

        public void deleteFilm(long id)
        {
            bdd.films.Remove(bdd.films.Find(id));
            bdd.SaveChanges();
        }

        public Film getFilm(long id)
        {
            return bdd.films.Find(id);
        }

        /*public void AddFilmSaw(String login, long id)
        {
            bdd.filmsaw.Add(new FilmSaw(bdd.users.Find(login), bdd.films.Find(id)));
            bdd.SaveChanges();
        }*/

        public void Dispose()
        {
            bdd.Dispose();
        }
    }
}