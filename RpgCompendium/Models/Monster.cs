using System.Collections.Generic;

namespace RpgCompendium.Models
{
  public class Monster
  {
    public Monster()
    {
      // var EquipDictionary = new Dictionary<string, List<Armor>>
      //   {
      //     {"head", new List<Armor>{ }},
      //     { "face", new List<Armor>{ } },
      //     { "face", new List<Armor>{ } },
      //     { "torso", new List<Armor>{ } },
      //     { "back", new List<Armor>{ } },
      //     { "neck", new List<Armor>{ } },
      //     { "arm", new List<Armor>{ } },
      //     { "hand", new List<Armor>{ } },
      //     { "rings", new List<Armor>{ } },
      //     { "body", new List<Armor>{ } },
      //     { "waist", new List<Armor>{ } },
      //     { "legs", new List<Armor>{ } }
      //   };

      this.MainTypes = new HashSet<MonsterMainType>();
      this.Behaviors = new HashSet<MonsterBehavior>();
      this.Armors = new HashSet<MonsterArmor>();
      // this.Equip = EquipDictionary;
    }
    public int MonsterId { get; set; }
    public string MonsterName { get; set; }
    // public Dictionary<string, List<Armor>> Equip { get; set; }
    public virtual ICollection<MonsterMainType> MainTypes { get; set; }
    public virtual ICollection<MonsterBehavior> Behaviors { get; set; }
    public virtual ICollection<MonsterArmor> Armors { get; set; }

  }
}

//     this.mainHand = [],
//     this.offHand = [];