using System;
using Microsoft.EntityFrameworkCore;

namespace FilmCollector.Models
{
    public class FilmCollectionContext : DbContext
    {
        //this is the constructor
        public FilmCollectionContext(DbContextOptions<FilmCollectionContext> options ) : base (options)
        {
            //leave blank for now
        }

        //set up actual dataset (model) > pull set of data from database
        //set of instances of the FIlm Collection Dabase
        // varname {get; set;} will be the name of the table in the database
        public DbSet<CollectionResponse> Films { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            //database seeded entries
            mb.Entity<CollectionResponse>().HasData(

                new CollectionResponse
                {
                    FilmId = 1,
                    Title = "Megamind",
                    Year = 2010,
                    Category = "Family",
                    Director = "Tom McGrath",
                    Rating = "PG"
                 },
                new CollectionResponse
                {
                    FilmId = 2,
                    Title = "Spider-Man: Into the Spider-Verse",
                    Year = 2018,
                    Category = "Family",
                    Director = "Bob Persichetti",
                    Rating = "PG"
                },
                new CollectionResponse
                {
                    FilmId = 3,
                    Title = "Sherlock",
                    Year = 2018,
                    Category = "Crime",
                    Director = "Mark Gatiss",
                    Rating = "TV-14"
                }

            );
        }
    }
}
