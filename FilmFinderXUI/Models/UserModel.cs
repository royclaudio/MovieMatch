using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using FilmFinderXUI.Models;

namespace FilmFinderXUI.Models
{
	public class UserModel
	{
        [Key]
        public int UserId { get; set; }

        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        public string? Username { get; set; }

        public string? TempPassword { get; set; }

        [JsonIgnore]
        public string? PasswordHash { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MMMM yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Joined ")]
        public DateTime CreateDate { get; set; }

        public virtual ICollection<UserFeaturesModel>? UserInteractions { get; set; }
        public virtual ICollection<UserRatingsModel>? UserRatings { get; set; }
        public virtual ICollection<MovieCatalogModel>? MovieCatalogs { get; set; }


    }
}

