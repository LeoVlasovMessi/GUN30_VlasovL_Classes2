using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uroki
{
    public class Weapon
    {

        private string name;
        public string Name { get { return name; } }

        public Interval interval;

        public Weapon(string name)
        {
            this.name = name;
        }
        public Weapon(string name, Interval interval) : this(name)
        {
            this.interval = interval;
            SetDamageParams(interval.Min, interval.Max);
        }
        public Weapon() : this("UnknownWeapon") { }
        public void SetDamageParams(float minDamage, float maxDamage)
        {
            if (minDamage<1f) { minDamage = 1f; Console.WriteLine("Минимально возможный урон = 1f (Неверно введены данные)"); }
            if (maxDamage<=1f) { maxDamage = 10f; }
            if (minDamage>maxDamage)
            {
                float mid = minDamage;
                minDamage = maxDamage;
                maxDamage = mid;
                Console.WriteLine("Неверные данные (minDamage > maxDamage) " + name);
            }
            interval.Min = minDamage; interval.Max = maxDamage;
        }
        public float GetDamage()
        {
            return (interval.Min+interval.Max)/2;
        }
    }
}
