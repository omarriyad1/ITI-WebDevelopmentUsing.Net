using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D05
{
    internal static class Circle 
    {
       static double PI = 3.14;

        static int radius;

        static int counter;

        static Circle()
        {
            Console.WriteLine($"Counter Before {counter}");
            counter++;
            Console.WriteLine($"Counter After {counter}");
        }
        //public Circle(int _radius)
        //{
        //    Console.WriteLine("inside instance  class");
        //    counter++;
        //    Console.WriteLine(counter);
        //    radius = _radius; 
        //}

        public static double CalcArea()
        {
            return radius * radius * PI; 
        }

    }
}
