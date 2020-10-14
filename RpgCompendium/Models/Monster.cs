using System.Collections.Generic;

namespace RpgCompendium.Models
{
  public class Monster
  {
    public int MonsterId { get; set; }
    public string MonsterName { get; set; }
    public string MonsterMainType { get; set; }
    public string MonsterBehaviors { get; set; }
  }
}