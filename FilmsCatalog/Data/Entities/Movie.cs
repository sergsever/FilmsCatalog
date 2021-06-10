using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmsCatalog.Data.Entities
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
		[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
		public DateTime Release { get; set; }
        public string Description { get; set; }
        public List<Actor> FilmActors { get; set; }
		public Director Director { get; set; }
		public string UserWhoAdded { get; set; }
    }
}
