using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom.Core.Creatures;

public class Beholder : Monster
{
    public Beholder() : base("Beholder", 20)
    {

    }
    public override AttackResult Attack(Creature opponent, int damage = 10)
    {
        if (opponent.Health > Health)
            damage = 10;

        return base.Attack(opponent, damage);

    }


}
