using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IclonableEx
{
    class Car : ICloneable
    {
        int width;

        public Car(int width)
        {
            this.width = width;
        }

        public object Clone()
        {
            return new Car(this.width);
        }

        public override string ToString()
        {
            return string.Format("Width of car = {0}", this.width);
        }
    }

    class Program
    {
        static void Main()
        {
            Car carOne = new Car(2000);
            Car carTwo = carOne.Clone() as Car;

            Console.WriteLine("{0}mm", carOne);
            Console.WriteLine("{0}mm", carTwo);
            Console.ReadKey();
        }
    }
}
