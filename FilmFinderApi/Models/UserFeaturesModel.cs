using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MovieMauiAPI.Models;

namespace MovieMauiAPI.Models
{
    public class UserFeaturesModel
    {
        // create the average features 
        // user liked history
        [Key]
        public int FeaturesId { get; set; }

        [ForeignKey("UserModel")]
        public int? UserId { get; set; }
        public virtual UserModel? User { get; set; }
        [ForeignKey("MovieCatalogModel")]
        public int? MovieId { get; set; }
        public virtual MovieCatalogModel? MovieCatalog { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MMMM yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Added: ")]
        public DateTime CreateDate { get; set; }
        // ... Features ... //
        public int Musical { get; set; }
        public int Family { get; set; }
        public int Reality_TV { get; set; }
        public int Western { get; set; }
        public int Comedy { get; set; }
        public int Mystery { get; set; }
        public int Music { get; set; }
        public int Fantasy { get; set; }
        public int News { get; set; }
        public int Adventure { get; set; }
        public int Documentary { get; set; }
        public int Crime { get; set; }
        public int Horror { get; set; }
        public int Romance { get; set; }
        public int Sci_Fi { get; set; }
        public int Sport { get; set; }
        public int Animation { get; set; }
        public int Biography { get; set; }
        public int War { get; set; }
        public int History { get; set; }
        public int Action { get; set; }
        public int Short { get; set; }
        public int Thriller { get; set; }
        public int Drama { get; set; }
    
    }
}
