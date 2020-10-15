using System.Collections.Generic;

namespace RpgCompendium.Models
{
  public class Armor
  {
    public Armor()
    {
      this.Monsters = new HashSet<MonsterArmor>();
    }

    public int ArmorId { get; set; }
    public string ArmorName { get; set; }
    public string ArmorDescription { get; set; }
    public string ArmorSlot { set; get; }
    // public int ArmorClass { get; set; }
    // public string ArmorType { get; set; }
    // public string ArmorWorth { get; set; }
    // public int ArmorHp { get; set; }
    // public int ArmorLevel { get; set; }
    // public string ArmorStatus { get; set; }
    // public string ArmorFlags { get; set; }
    // public string ArmorRarity { get; set; }
    public ICollection<MonsterArmor> Monsters { get; set; }
  }
}
//slot,acBonus,type,name,Id,worth,Hp,level,status,flags,rarityA