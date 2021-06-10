using FilmsCatalog.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmsCatalog.Data
{
    public class MovieDao : IDAO<Movie, int>
    {
        private MoviesDbContext dbcontext;
        public MovieDao(MoviesDbContext context)
        {
            dbcontext = context;

        }
        public IEnumerable<Movie> GetAll()
        {
            return dbcontext.Movies.ToList();
        }

        public void Add(Movie movie)
        {
            dbcontext.Movies.Add(movie);
            dbcontext.SaveChanges();
        }

        public void Update(Movie movie)
        {
			Movie old = dbcontext.Movies.Find(movie.Id);
			old.Title = movie.Title;
			old.Release = movie.Release;
			old.Description = movie.Description;
			old.FilmActors = movie.FilmActors;
			if (movie.Director != null)
			{
				Director director = dbcontext.Directors.Find(movie.Id);
				old.Director = director;
			}
            dbcontext.SaveChanges();
        }

		public Movie Find(int key)
		{
			Movie movie = dbcontext.Movies.Find(key);
			return movie;
		}

		public void Delete(Movie movie)
		{
			dbcontext.Movies.Remove(movie);
			dbcontext.SaveChanges();
		}

		public IEnumerable<Director> GetDirectors()
		{
			return dbcontext.Directors.ToList();
		}
    }
}
