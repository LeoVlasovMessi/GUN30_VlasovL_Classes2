using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uroki
{
    public struct Interval
    {
        public Interval(int minValue, int maxValue)
        {
            if (minValue > maxValue)
            {
                int mid = minValue;
                minValue = maxValue;
                maxValue = mid;
                if (minValue<0) minValue = 0;
                if (maxValue<0) maxValue = 0;
                if (minValue==maxValue) maxValue += 10;
                Console.WriteLine("Некорректные входные данные...");
            }
            Min = minValue; Max = maxValue;
        }

        Random rand = new Random();
        public float Min { get; set; }
        public float Max { get; set; }

        public int Get { get { return rand.Next((int)Min, (int)Max); } }
    }
}
