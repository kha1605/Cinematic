using System.ComponentModel.DataAnnotations;

namespace demo_mvc.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name="Profile picture URl")]
        public string ProfilePictureURL { get; set; }
        [Display(Name ="Full Namefile ")]
        public string fullname {  get; set; }
        [Display(Name = "Biography")]
        public string bio {  get; set; }
        //Relationships
        public List<Actor_Movie> Actors_Movie { get; set; }
    }
}
