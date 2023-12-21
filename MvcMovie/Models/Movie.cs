using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? Title { get; set; }

        [StringLength(120, MinimumLength = 3)]
        public string? Director { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string? Genre { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Range(1.0, 10.0)]
        public double? Rating { get; set; }

        [Display(Name = "Made Profit")]
        [Range(typeof(bool), "false", "true")]
        public bool? MadeProfit { get; set; }
    }
}
