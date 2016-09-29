using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieDb.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [Display(Name = "Naslov")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }


        [Display(Name = "Datum premijere")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }


        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        [StringLength(30)]
        [Display(Name = "Zanr")]
        public string Genre { get; set; }
        [Display(Name = "Ocijena")]
        public int Grade { get; set; }
        [Display(Name = "Redatelj")]
        public string Director { get; set; }
        [Display(Name = "Glumci")]
        public String Actors { get; set; }

      
    }
}
