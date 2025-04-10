namespace DungeonsOfDoom.Core.Creatures;

public abstract class Monster : Creature
{

    public static int MonsterCount { get; set; }

    public override int Health
    {
        get => base.Health;
        set
        {
            base.Health = value;
            if (!IsAlive)
                MonsterCount--;
        }
    }
    public Monster(string name, int health) : base(name, health)
    {
        MonsterCount++;
    }


}
