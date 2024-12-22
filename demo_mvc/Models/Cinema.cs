using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using demo_mvc.Data.Base;

namespace demo_mvc.Models
{
    public class Cinema :IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display (Name="Cinema logo")]
        public string Logo { get; set; }
        [Display(Name="Cinema name")]
        public string Name { get; set; }
        [Display (Name="Description")]
        public string Description { get; set; }
        //Relationships
     
        public List<Movie> Movie { get; set; }
    }
}
