using Microsoft.EntityFrameworkCore;

namespace RpgCompendium.Models
{
  public class RpgCompendiumContext : DbContext
  {
    public virtual DbSet<Monster> Monsters { get; set; }
    // public virtual DbSet<Type> Types { get; set; }
    // public virtual DbSet<Behavior> Behaviors { get; set; }
    

    public RpgCompendiumContext(DbContextOptions options) : base(options) { }
  }
}