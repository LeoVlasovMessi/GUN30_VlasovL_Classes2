using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Uroki
{
    public class Unit
    {

        public Weapon weapon = new Weapon();
        public Helm helm = new Helm();
        public Shell shell = new Shell();
        public Boots boots = new Boots();

        private string name;
        public string Name { get { return name; } }
        private float health;
        public float Health { get { return health; } set { health = value; } }

        private const int DefaultDamage = 5;

        public Interval interval;


        private float armor;
        public float Armor
        {
            get
            {
                armor = helm.Armor + shell.Armor + boots.Armor;
                armor  = (float)Math.Round(armor, 2);
                return armor;
            }
        }

        public Unit(string name)
        {
            this.name = name;
            weapon = new Weapon();
            helm = new Helm();
            shell = new Shell();
            boots = new Boots();
        }

        public Unit() : this("Unknown Unit") { }

        public Unit(string name, int min, int max) : this(name)
        {
            interval.Min = min; interval.Max = max;
        }

        public float RealHealth()
        {
            return Health * (1f+Armor);
        }

        public bool SetDamage(float value)
        {
            health = Health - value*Armor;

            return Health<=0f;
        }

        public void EquipWeapon(Weapon weapon)
        {
            this.weapon = weapon;
        }

        public void EquipHelm(Helm helm)
        {
            this.helm = helm;
        }
        public void EquipShell(Shell shell)
        {
            this.shell = shell;
        }
        public void EquipBoots(Boots boots)
        {
            this.boots = boots;
        }

    }
}
