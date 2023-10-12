using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D05
{
    internal  class Point2D 
    {
      protected  int x;
      protected  int y;


        public Point2D()
        {
            x = y = 5 ; 
        }
        public Point2D(int _x , int _y)
        {
            x = _x ;
            y = _y; 

        }
        public Point2D(int _x) : this(_x, default) { }
        public Point2D(Point2D oldPoint )
        {
            x = oldPoint.x;
            y = oldPoint.y; 
        }
      

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }  
            set { y = value; }

        }


        public void Print() => Console.WriteLine($"({x},{y})");

        public int Product() => x * y;     
    }
}
