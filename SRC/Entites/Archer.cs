namespace GFTRPG.SRC.Entites
{
  public class Archer : characters
  {
    public Archer(string Name, string HeroRace, string HeroClass, int Level, int Health)
    {
      this.Name = Name;
      this.Level = Level;
      this.HeroRace = HeroRace;
      this.HeroClass = HeroClass;
      this.Health = Health;
    }
    public override string Atack()
    {
      return this.Name + " attacked with his arrow";
    }
    public string Atack(int bonus)
    {
      if (bonus > 10)
      {
        return this.Name + " critical arrow + " + bonus;
      }
      else
      {
        return this.Name + " painful arrow + " + bonus;
      }

    }
  }
}
