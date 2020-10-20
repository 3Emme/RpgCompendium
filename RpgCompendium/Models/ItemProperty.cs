using System.Collections.Generic;

namespace RpgCompendium.Models
{
  public class ItemProperty
  {
    public ItemProperty()
    {
      this.Armor = new HashSet<ItemPropertyJoin>();
      this.Weapon = new HashSet<ItemPropertyJoin>();
    }

    public int ItemPropertyId { get; set; }
    public string ItemPropertyName { get; set; }
    public string ItemPropertyDescription { get; set; }
    public string ItemPropertyFlags { set; get; }
    
    public virtual ICollection<ItemPropertyJoin> Armor { get; set; }
    public virtual ICollection<ItemPropertyJoin> Weapon { get; set; }
    
  }
}
//slot,acBonus,type,name,Id,worth,Hp,level,status,flags,rarityA