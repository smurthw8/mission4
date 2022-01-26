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
    }
}
