using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D05
{
    internal class Point3D : Point2D
    {
        
        int z;

        public Point3D() : base() { z = 5;  }
      

        public Point3D(int _x , int _y , int _z) : base(_x ,_y)
        {            
            z = _z; 
        }

        public int Z
        {
            get { return z;  }
            set { z = value; }
        }


        public void Print3D() => Console.WriteLine($"({x},{y},{z})");

        // Method Hide 
        public new int Product() =>base.Product() * z; 
    }
}
