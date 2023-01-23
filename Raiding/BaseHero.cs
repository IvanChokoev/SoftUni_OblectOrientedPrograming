namespace Raiding
{
    public abstract class BaseHero
    {
        public BaseHero(string name, int power)
        {
            this.Power = power;
            this.Name = name;
        }
        public string Name { get; }
        public int Power { get; }
        public abstract string CastAbility();
     
    }
}
