using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D05
{
    internal abstract class InstructorV2
    {

    }
    internal abstract class Instructor
    {
        protected string name;

        public abstract void PrintName();

        public abstract int PrinNum(int num); 
    }

    class PartTimeIns :   Instructor,  IComparable, ICloneable
    {
        public override int PrinNum(int num)
        {
            return num * 100;
        }

        public override void PrintName()
        {

        }
        public object Clone()
        {
            throw new NotImplementedException();
        }

        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }
    }

    class FullTimeIns : Instructor
    {
        public override int PrinNum(int num)
        {
            return num * 1000;
        }

        public override void PrintName()
        {
            throw new NotImplementedException();
        }


    }
}
