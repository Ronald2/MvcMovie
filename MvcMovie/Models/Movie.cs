using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [Required,StringLength(60,MinimumLength =3)]
        public string Title { get; set; }

        [Display(Name ="Release Date"),DataType(DataType.Date),DisplayFormat(DataFormatString ="{0:dd-MM-yyyy}",ApplyFormatInEditMode =true)]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$"),Required]
        public string Genre { get; set; }

        [DataType(DataType.Currency),Range(1,100)]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$"),MaxLength(5)]
        public string Rating { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string Director { get; set; }

    }

    public class MovieDbContext: DbContext
    {
        public DbSet<Movie> Movies { get; set; }

    }
}