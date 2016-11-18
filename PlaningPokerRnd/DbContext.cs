using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using PlaningPokerRnd.Entities;

namespace PlaningPokerRnd
{
    public class PokerDbContext : DbContext
    {
        public PokerDbContext() : base("PokerDb"){}

        public DbSet<Room> Rooms { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}