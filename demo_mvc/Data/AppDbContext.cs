using demo_mvc.Models;
using Microsoft.EntityFrameworkCore;

namespace demo_mvc.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {
        
        
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new 
            {
                am.ActorID,
                am.MovieID
            });
            modelBuilder.Entity<Actor_Movie>().HasOne(m =>m.Movie).WithMany(am =>am.Actor_Movie).HasForeignKey(am => am.MovieID);
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Actor).WithMany(am => am.Actors_Movie).HasForeignKey(am => am.ActorID);

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }

        public DbSet<Actor_Movie> Actors_Movies { get; set; }

        public DbSet<Cinema> Cinemas { get; set; }

        public DbSet<Producer> Producers { get; set; }
    }
}
