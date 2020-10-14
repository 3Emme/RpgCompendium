using Microsoft.EntityFrameworkCore;

namespace RpgCompendium.Models
{
  public class RpgCompendiumContext : DbContext
  {
    public virtual DbSet<Monster> Monsters { get; set; }
    public virtual DbSet<MainType> MainTypes { get; set; }
    public virtual DbSet<Behavior> Behaviors { get; set; }
    public virtual DbSet<MonsterMainType> MonsterMainTypes { get; set; }

    public RpgCompendiumContext(DbContextOptions options) : base(options) { }
  }
}