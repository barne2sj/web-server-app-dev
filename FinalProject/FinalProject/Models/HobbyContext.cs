using Microsoft.EntityFrameworkCore;


namespace FinalProject.Models
{
    public class HobbyContext : DbContext
    {
        public HobbyContext(DbContextOptions<HobbyContext> options)
            : base(options)
        { }
        public DbSet<Hobby> Hobbys { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hobby>().HasData(
                new Hobby { HobbyId = 1, HobbyName = "Cooking", HobbyDescription = "Cooking for my family makes me happy" },
                new Hobby { HobbyId = 2, HobbyName = "Swimming", HobbyDescription = "Swimming in water makes me feel relax" },
                new Hobby { HobbyId = 3, HobbyName = "Video Games", HobbyDescription = "Playing with my friends" },
                new Hobby { HobbyId = 4, HobbyName = "Art Journal", HobbyDescription = "Creating in my art journal allows me to express myself" },
                new Hobby { HobbyId = 5, HobbyName = "Photography", HobbyDescription = "Taking photos of random things such as buildings." },
                new Hobby { HobbyId = 6, HobbyName = "Films", HobbyDescription = "Watching and analyzing movies while having meaningful discussions." }
               );
        }
    }
}
