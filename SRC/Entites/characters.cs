namespace GFTRPG.SRC.Entites
{


  public abstract class characters

  {
    public string Name;
    public int Level;
    public int Health;
    public string HeroRace;
    public string HeroClass;
    public characters(string Name, string HeroRace, string HeroClass, int Level, int Health)
    {
      this.Name = Name;
      this.Level = Level;
      this.HeroRace = HeroRace;
      this.HeroClass = HeroClass;
      this.Health = Health;
    }

    public characters()
    {
    }
    public override string ToString()
    {
      return this.Name + " " + this.Level + " " + this.HeroRace + " " + this.HeroClass + " " + this.Health;

    }
    public virtual string Atack()
    {
      return this.Name + " atacou";
    }
  }
}