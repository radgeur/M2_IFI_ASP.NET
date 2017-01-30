using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Objects.DataClasses;
using System.ComponentModel.DataAnnotations;

namespace FilmManager.Models
{
    public class User
    {
        [Key]
        public string login { get; set; }
        public string password { get; set; }
        public bool admin { get; set; }
    }

    public class Film
    {
        public long id { get; set; }
        public string title { get; set; }

        public override bool Equals(Object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Film f = (Film)obj;
            return this.id == f.id;
        }
    }

    public class FilmSaw
    {
        public virtual User user { get; set; }
        public virtual Film film { get; set; }
    }

    public class BddContext : DbContext
    {
        public BddContext() : base("ConnectionString")
        {

        }
        public DbSet<User> users { get; set; }
        public DbSet<Film> films { get; set; }
        public DbSet<FilmSaw> filmsaw { get; set; }
    }
}