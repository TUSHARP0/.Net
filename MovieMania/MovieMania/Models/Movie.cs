using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Asn1.Mozilla;
using System.ComponentModel.DataAnnotations;

namespace MovieMania.Models
{
    [Index(nameof(MovieName),IsUnique =true)]
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Movie Name is required")]
        public string MovieName { get; set; }

        [Required(ErrorMessage = "Producer Name is required")]
        public string producer { get;set; }

        public double ticketPrice { get; set; }

        public DateOnly releaseDate { get; set; }


    }
}
