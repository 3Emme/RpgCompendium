using Microsoft.EntityFrameworkCore;

namespace RpgCompendium.Models
{
  public class RpgCompendiumContext : DbContext
  {
    public DbSet<Monster> Monsters { get; set; }
    public DbSet<MainType> MainTypes { get; set; }
    public DbSet<Behavior> Behaviors { get; set; }
    public DbSet<Armor> Armors { get; set; }
    public DbSet<MonsterMainType> MonsterMainTypes { get; set; }
    public DbSet<MonsterBehavior> MonsterBehaviors { get; set; }
    public DbSet<MonsterArmor> MonsterArmor { get; set; }

    public RpgCompendiumContext(DbContextOptions options) : base(options) { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}