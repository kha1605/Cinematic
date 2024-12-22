using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using demo_mvc.Data;
using demo_mvc.Data.Base;

namespace demo_mvc.Models
{
    public class Movie :IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description  { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime startdate { get; set; }
        public DateTime enddate { get; set; }
        public MovieCategory MovieCategory { get; set; }

        //Relationships
        public List<Actor_Movie> Actor_Movie { get; set; }

        //Cinema
        public int CinemaID { get; set; }
        [ForeignKey("CinemaID")]
        public Cinema Cinema { get; set; }

        //Producer
        public int ProducerID { get; set; }
        [ForeignKey("ProducerID")]
        public Producer Producer { get; set; }


    }
}
