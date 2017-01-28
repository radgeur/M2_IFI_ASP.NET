using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FilmManager.Models
{
    public class User
    {
        public string login { get; set; }
        public string password { get; set; }
        public bool admin { get; set; }
    }

    public class Film
    {
        public int id { get; set; }
        public string title { get; set; }
    }

    public class FilmSaw
    {
        public virtual User user { get; set; }
        public virtual Film film { get; set; }
    }

    public class BddContext : DbContext
    {
        public DbSet<User> users { get; set; }
        public DbSet<Film> films { get; set; }
    }
}