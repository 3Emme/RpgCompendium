using System.Collections.Generic;

namespace RpgCompendium.Models
{
  public class Monster
  {
    public Monster()
    {
      this.MainTypes = new HashSet<MonsterMainType>();
    }
    public int MonsterId { get; set; }
    public string MonsterName { get; set; }
    public virtual ICollection<MonsterMainType> MainTypes { get; set; }
  }
}