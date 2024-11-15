using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uroki
{
    public class Dungeon
    {
        public Room[] rooms;

        public Unit unit1 = new Unit("Super Unit");
        public Unit unit2 = new Unit("Not a Super Unit");
        public Unit unit3 = new Unit("Warrior");

        public Weapon weapon1 = new Weapon("Sword of Truth");
        public Weapon weapon2 = new Weapon("Fist");
        public Weapon weapon3 = new Weapon("Punisher's ax");


        public Dungeon()
        {
            rooms = new Room[3];
            unit1.Health = 95;
            unit1.shell.Armor = 1;
            unit2.Health = 15;
            unit2.boots.Armor = 0.1f;
            unit3.Health = 57;
            unit3.helm.Armor = 0.4f;

            weapon1.interval.Min = 20;
            weapon1.interval.Max = 90;
            weapon2.interval.Min = 1;
            weapon2.interval.Max = 10;
            weapon3.interval.Min = 15;
            weapon3.interval.Max = 35;

            rooms[0] = new Room(unit1, weapon1);
            rooms[1] = new Room(unit2, weapon2);
            rooms[2] = new Room(unit3, weapon3);
        }

        void UnitInfo(Unit unit)
        {
            Console.WriteLine("Имя: " + unit.Name);
            Console.WriteLine("общий уровень брони: " + unit.Armor);
            Console.WriteLine("Здоровье: " + unit.Health);
            Console.WriteLine("Фактическое здоровье: " + unit.RealHealth());
        }

        void WeaponInfo(Weapon weapon)
        {
            Console.WriteLine("Название оружия: " + weapon.Name);
            Console.WriteLine("MinDamage = " + weapon.interval.Min);
            Console.WriteLine("MaxDamage = " + weapon.interval.Max);
        }

        public void ShowRooms()
        {
            for (int i = 0; i < rooms.Length; i++)
            {
                var room = rooms[i];
                Console.WriteLine("Unit of room " + (i+1) + " "); UnitInfo(room.unit);
                Console.WriteLine("Weapon of room " + (i+1) + " "); WeaponInfo(room.weapon);
                Console.WriteLine("—");
            }
        }

    }

}