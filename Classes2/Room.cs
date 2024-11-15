using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uroki
{
    public struct Room
    {
        public Unit unit;
        public Weapon weapon;

        public Room(Unit unit, Weapon weapon)
        {
            this.unit = unit;
            this.weapon = weapon;
        }
    }
}