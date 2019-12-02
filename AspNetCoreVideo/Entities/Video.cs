using AspNetCoreVideo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreVideo.Entities
{
    public class Video
    {
        public int Id { get; set; }

        [Required, MinLength(3), MaxLength(80)]
        public string Title { get; set; }
        [Display(Name = "Film Genre")]
        public Genres Genre { get; set; }
        //public int GenreId { get; set; }
    }
}
