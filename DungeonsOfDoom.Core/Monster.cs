namespace DungeonsOfDoom.Core
{
    public class Monster
    {
        public Monster(string name, int health)
        {
            Name = name;
            Health = health;
        }

        public string Name { get; set; }
        public int Health { get; set; }
        public bool IsAlive => Health > 0;
    }
}
