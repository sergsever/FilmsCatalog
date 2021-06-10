using FilmsCatalog.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmsCatalog.Data
{
    public class MoviesDbContext : DbContext
    {
        public MoviesDbContext() : base(getOptions())
        {

        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
		public DbSet<Director> Directors { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Movie>().HasKey(m => m.Id);
            builder.Entity<Actor>().HasKey(a => a.Id);
			builder.Entity<Director>().HasKey(d => d.Id);

			builder.Entity<Movie>().HasMany(e => e.FilmActors);
			builder.Entity<Movie>().HasOne(m => m.Director);
			builder.Entity<Director>().HasData(new Director() {Id=1, Name = "Дон Сигел" });
			builder.Entity<Director>().HasData(new Director() {Id=2,Name = "Рауль Уолш" });
            builder.Entity<Actor>().HasData(new Actor() {Id=1, Name = "Джон Уэйн" });
            builder.Entity<Actor>().HasData(new Actor() { Id=2, Name = "Клин Иствуд" });
            builder.Entity<Actor>().HasData(new Actor() { Id=3, Name = "Чарльз Бронсон" });
            builder.Entity<Movie>().HasData(new Movie() { Id=1, Title = "Большой след", Description = "вестерн", Release = DateTime.Parse("01/01/1930") });
            builder.Entity<Movie>().HasData(new Movie() { Id=2,Title = "Грязный Гарри", Description = "детектив", Release = DateTime.Parse("01/01/1971") });
            builder.Entity<Movie>().HasData(new Movie() { Id=3, Title = "Дилижанс", Description = "вестерн", Release = DateTime.Parse("01/01/1939") });
            builder.Entity<Movie>().HasData(new Movie() { Id=4, Title = "Самый длинный день", Description = "военный", Release = DateTime.Parse("01/01/1962") });
            builder.Entity<Movie>().HasData(new Movie() { Id=5, Title = "В седле", Description = "детектив", Release = DateTime.Parse("01/01/1944") });
            builder.Entity<Movie>().HasData(new Movie() { Id=6, Title = "За пригрошню долларов", Description = "вестерн", Release = DateTime.Parse("01/01/1964") });
            builder.Entity<Movie>().HasData(new Movie() { Id=7, Title = "Хороший, плохой, злой", Description = "вестерн", Release = DateTime.Parse("01/01/1966") });
            builder.Entity<Movie>().HasData(new Movie() { Id=8,Title = "Куда не долетают орлы", Description = "военный", Release = DateTime.Parse("01.01/1968") });
            builder.Entity<Movie>().HasData(new Movie() { Id=9, Title = "Большой побег", Description = "военный", Release = DateTime.Parse("01/01/1963") });
            builder.Entity<Movie>().HasData(new Movie() { Id=10, Title = "Белый бизон", Description = "вестерн", Release = DateTime.Parse("01/01/1977") });

        }

		protected static DbContextOptions<MoviesDbContext> getOptions()
		{
			IConfiguration config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
			string connectionString = config.GetConnectionString("defaultConnection");

			DbContextOptions<MoviesDbContext> options = new DbContextOptionsBuilder<MoviesDbContext>().UseSqlServer(connectionString).Options;
			return options;
		}

    }

}
