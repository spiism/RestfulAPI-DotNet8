using Microsoft.EntityFrameworkCore;
using RestfulAPI_DotNet8.Entities;

namespace RestfulAPI_DotNet8.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet <SuperHero> SuperHeroes { get; set; }
    }
}
