using System.Collections.Generic;

namespace RpgCompendium.Models
{
  public class Monster
  {
    public Monster()
    {
      this.MainTypes = new HashSet<MonsterMainType>();
      this.Behaviors = new HashSet<MonsterBehavior>();
    }
    public int MonsterId { get; set; }
    public string MonsterName { get; set; }
    public virtual ICollection<MonsterMainType> MainTypes { get; set; }
    public virtual ICollection<MonsterBehavior> Behaviors { get; set; }
  }
}