using Microsoft.EntityFrameworkCore;
using practice1.API.Model;

namespace practice1.API.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext>options):base(options)
        {
            
        }

        public DbSet<Person> Persons {set;get;}
    }
}