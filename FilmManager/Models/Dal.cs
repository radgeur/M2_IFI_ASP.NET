﻿using System;
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

        public void deleteFilm(long id)
        {
            bdd.films.Remove(bdd.films.Find(id));
        }

        public Film getFilm(long id)
        {
            return bdd.films.Find(id);
        }

        public void Dispose()
        {
            bdd.Dispose();
        }
    }
}