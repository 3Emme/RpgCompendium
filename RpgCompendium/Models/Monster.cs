using System.Collections.Generic;

namespace RpgCompendium.Models
{
  public class Monster
  {
    public Monster()
    {      
      this.MainTypes = new HashSet<MonsterMainType>();
      this.Behaviors = new HashSet<MonsterBehavior>();
      this.Armors = new HashSet<MonsterArmor>();      
    }
    public int MonsterId { get; set; }
    public string MonsterName { get; set; }    
    public virtual ICollection<MonsterMainType> MainTypes { get; set; }
    public virtual ICollection<MonsterBehavior> Behaviors { get; set; }
    public virtual ICollection<MonsterArmor> Armors { get; set; }
  }
}

