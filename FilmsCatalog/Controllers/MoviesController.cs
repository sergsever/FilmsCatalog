using FilmsCatalog.Data;
using FilmsCatalog.Data.Entities;
using FilmsCatalog.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmsCatalog.Controllers
{
    public class MoviesController : Controller
    {
        private MoviesModel model;

        public MoviesController(MoviesModel model)
        {
			this.model = model;
//			model = new MoviesModel(new MovieDao(new MoviesDbContext()));
		}
		public IActionResult Index()
        {
			//            model.Init(); 
//			MoviesModel mmodel = new MoviesModel(new MovieDao(new MoviesDbContext()));
			model.Init();
            return View(model);
        }

		
		public IActionResult Edit(int id)
		{
			Movie movie = model.Find(id);
			return View(movie);
		}

		public IActionResult Add()
		{
			Movie movie = new Movie();
			return View("Edit", movie);
		}
		[Authorize]
		public IActionResult Save(int id, string title, DateTime release, string director, string description)
		{
			model.Init();
			SelectListItem item =  model.Directors.Where(d => d.Text == director).FirstOrDefault();
			Director dir = new Director() { Id = int.Parse(item.Value), Name = item.Text };
			Movie movie = new Movie() { Id = id, Title = title, Release = release, Description =description, Director=dir };
			movie.UserWhoAdded = User.Identity.Name;
			model.Save(movie);
			return View("Index", model);
		}

		public IActionResult Delete(int id)
		{
			model.Delete(id);
			model.Init();
			return View("Index", model);

		}
    }
}
