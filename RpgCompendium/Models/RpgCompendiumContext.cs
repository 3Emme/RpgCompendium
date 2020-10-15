using Microsoft.EntityFrameworkCore;

namespace RpgCompendium.Models
{
  public class RpgCompendiumContext : DbContext
  {
    public virtual DbSet<Monster> Monsters { get; set; }
    public virtual DbSet<MainType> MainTypes { get; set; }
    public virtual DbSet<Behavior> Behaviors { get; set; }
    public virtual DbSet<Armor> Armors { get; set; }
    public virtual DbSet<MonsterMainType> MonsterMainTypes { get; set; }
    public virtual DbSet<MonsterBehavior> MonsterBehaviors { get; set; }
    public virtual DbSet<MonsterArmor> MonsterArmor { get; set; }

    public RpgCompendiumContext(DbContextOptions options) : base(options) { }
  }
  // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  //       {
  //           optionsBuilder.UseLazyLoadingProxies();
  //       }
}