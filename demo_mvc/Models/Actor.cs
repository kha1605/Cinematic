using System.ComponentModel.DataAnnotations;

namespace demo_mvc.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile picture URl")]
        [Required(ErrorMessage ="Profilepicture pciture is required")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full Name ")]
        [Required(ErrorMessage = "Fullname pciture is required")]
        [StringLength (50, MinimumLength =3, ErrorMessage ="Full name must be between 3 and 50 chars")]
        public string fullname { get; set; }
        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required")]

        public string bio { get; set; }
        //Relationships
        public List<Actor_Movie>? Actors_Movie { get; set; }
    }
}