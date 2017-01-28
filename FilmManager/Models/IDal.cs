using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmManager.Models
{
    public interface IDal : IDisposable
    {
        List<User> getUsers();
        List<Film> getFilms();
    }
}