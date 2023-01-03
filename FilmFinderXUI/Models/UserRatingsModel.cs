using System.ComponentModel.DataAnnotations;
using FilmFinderXUI.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace FilmFinderXUI.Models
{
    public class UserRatingsModel
    {
        // ratings matrix
        // user liked history
        [Key]
        public int RatingsId { get; set; }

        [ForeignKey("UserModel")]
        public int? UserId { get; set; }
        public virtual UserModel? User { get; set; }
        [ForeignKey("MovieCatalogModel")]
        public int? MovieId { get; set; }
        public virtual MovieCatalogModel? MovieCatalog { get; set; }

        public int Rating { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MMMM yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Added: ")]
        public DateTime CreateDate { get; set; }
    }
}
