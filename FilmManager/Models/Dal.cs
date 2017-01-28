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

        public List<User> getUsers()
        {
            return bdd.users.ToList();
        }

        public List<Film> getFilms()
        {
            return bdd.films.ToList();
        }

        public void Dispose()
        {
            bdd.Dispose();
        }
    }
}