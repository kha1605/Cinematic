using System.ComponentModel.DataAnnotations;
using demo_mvc.Data.Base;

namespace demo_mvc.Models
{
    public class Producer:IEntityBase
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
