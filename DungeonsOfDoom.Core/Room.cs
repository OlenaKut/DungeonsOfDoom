﻿using DungeonsOfDoom.Core.Creatures;
using DungeonsOfDoom.Core.Items;

namespace DungeonsOfDoom.Core;

public class Room
{
    public Monster MonsterInRoom { get; set; }
    public Item ItemInRoom { get; set; }
}
