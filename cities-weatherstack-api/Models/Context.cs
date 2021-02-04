using Microsoft.EntityFrameworkCore;

namespace cities_weatherstack_api.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<City> Cities { get; set; }
    }
}
