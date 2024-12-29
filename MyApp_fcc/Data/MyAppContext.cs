using Microsoft.EntityFrameworkCore;
using MyApp_fcc.Models;

namespace MyApp_fcc.Data
{
    public class MyAppContext : DbContext
    {
        public MyAppContext(DbContextOptions<MyAppContext> options) : base(options) { }

        public DbSet<Item> Items { get; set; }
    }
}
