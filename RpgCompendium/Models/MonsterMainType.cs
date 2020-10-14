namespace RpgCompendium.Models
{
  public class MonsterMainType
  {
    public int MonsterMainTypeId { get; set; }
    public int MonsterId { get; set; }
    public int MainTypeId { get; set; }
    public Monster Monster { get; set; }
    public MainType MainType { get; set; }
  }
}