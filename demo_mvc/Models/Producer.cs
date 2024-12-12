using System.ComponentModel.DataAnnotations;

namespace demo_mvc.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Profile Picture ")]
        public string ProfilePictureURL { get; set; }
        [Display(Name ="Full Name")]
        public string fullname { get; set; }
        [Display(Name ="Biography")]
        public string bio { get; set; }
        //Relationships
        public List<Movie> Movie { get; set; }
    }
}
