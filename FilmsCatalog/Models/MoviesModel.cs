using FilmsCatalog.Data;
using FilmsCatalog.Data.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmsCatalog.Models
{
    public class MoviesModel
    {
        private MovieDao dao { get; set; }
        private bool IsInitialized = false;
		public List<Movie> Movies { get; set; }

		public List<SelectListItem> Directors { get; set; }

		public MoviesModel(MovieDao dao)
        {
            this.dao = dao;
        }

        public void Init()
		{
			if (!IsInitialized)
			{
				Movies = dao.GetAll().ToList();
				IsInitialized = true;
				List<Director> directors = dao.GetDirectors().ToList();
				Directors = new List<SelectListItem>();
				foreach(Director d in directors)
				{
					SelectListItem item = new SelectListItem() { Text = d.Name, Value = d.Id.ToString() };
					Directors.Add(item);
				}
			}
        }

		public Movie Find(int key)
		{
			return dao.Find(key);
		}

		public void Save(Movie movie)
		{
			if (dao.Find(movie.Id) == null)
				dao.Add(movie);
			else
				dao.Update(movie);
		}

		public void Delete(int id)
		{
			Movie movie = dao.Find(id);
			dao.Delete(movie);
		}

        
          
        
    }
}
