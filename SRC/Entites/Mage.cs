namespace GFTRPG.SRC.Entites
{
  public class Mage : characters
  {
    public Mage(string Name, string HeroRace, string HeroClass, int Level, int Health)
    {
      this.Name = Name;
      this.Level = Level;
      this.HeroRace = HeroRace;
      this.HeroClass = HeroClass;
      this.Health = Health;
    }
    public override string Atack()
    {
      return this.Name + " Used fireball";
    }
    public string Atack(int bonus)
    {
      if (bonus > 10)
      {
        return this.Name + " Used ultra fireball + " + bonus;
      }
      else
      {
        return this.Name + "Used high fireball +" + bonus;
      }
    }
  }
}