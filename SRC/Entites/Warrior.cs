namespace GFTRPG.SRC.Entites
{
  public class Warrior : characters
  {
    public Warrior(string Name, string HeroRace, string HeroClass, int Level, int Health)
    {
      this.Name = Name;
      this.Level = Level;
      this.HeroRace = HeroRace;
      this.HeroClass = HeroClass;
      this.Health = Health;
    }
    public override string Atack()
    {
      return this.Name + " normal axe attack";
    }
    public string Atack(int bonus)
    {
      if (bonus > 10)
      {
        return this.Name + " vigorous ax attack + " + bonus;
      }
      else
      {
        return this.Name + " high axe attack + " + bonus;
      }
    }
  }
}