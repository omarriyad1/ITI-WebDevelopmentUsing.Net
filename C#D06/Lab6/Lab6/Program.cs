using System.Threading;
using System;

internal class Program
{
    class Duration
    {
        private int Hours;
        
        private int Minutes;

        private int Seconds;
        
        public void setHours(int hours)
        {
            Hours = hours;
        }
        public void SetMinutes(int minutes)
        {
            Minutes = minutes;
        }
      
        public void SetSeconds(int seconds)
        {
            Seconds = seconds;
        }
        public int getHours()
        {
            return Hours ;
        }
        public int getMinutes()
        {
           return Minutes ;
        }

        public int getSeconds()
        {
            return Seconds ;
        }


        public override string ToString()
        {
            return $"Hours: {Hours} Minutes: {Minutes} Seconds: {Seconds}";
        

        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Duration otherDuration = (Duration)obj;
            return Hours == otherDuration.Hours &&
                   Minutes == otherDuration.Minutes &&
                   Seconds == otherDuration.Seconds;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public Duration(int TotalSeconds)
        {
            int Totalminutes = TotalSeconds /60;
            int Totalhours = Totalminutes / 60;
            Totalminutes=Totalminutes-(Totalhours*60);
            TotalSeconds=TotalSeconds-(Totalminutes*60);
            Hours = Totalhours;
            Minutes = Totalminutes;
            Seconds = TotalSeconds;

        }
        public static Duration operator +(Duration a, Duration b) 
        {
            int hours = a.Hours + b.Hours;
            int minutes = a.Minutes + b.Minutes;
            int seconds = a.Seconds + b.Seconds;
            return new Duration(hours, minutes, seconds);
            
        }
        
            public static Duration operator +(Duration a, int total)
        {
            Duration d = new Duration(total);
            int hours = a.Hours + d.Hours;
            int minutes = a.Minutes + d.Minutes;
            int seconds = a.Seconds + d.Seconds;
            return new Duration(hours, minutes, seconds);

        }
        public static Duration operator +(int total , Duration a)
        {
            Duration d = new Duration(total);
            int hours = a.Hours + d.Hours;
            int minutes = a.Minutes + d.Minutes;
            int seconds = a.Seconds + d.Seconds;
            return new Duration(hours, minutes, seconds);

        }
        public static Duration operator ++ (Duration a) 
        {
            a = a + 60;
            return a;
        }
        public static Duration operator --(Duration a)
        {
            a.Minutes = a.Minutes-60;
            return a;
        }
        public static Boolean operator >(Duration a, Duration b)
        {
            int total1 = (a.Hours * 60 * 60) + (a.Minutes * 60) + a.Seconds;
            int total2 = (b.Hours * 60 * 60) + (b.Minutes * 60) + b.Seconds;
            if(total1 > total2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Boolean operator <(Duration a, Duration b)
        {
            int total1 = (a.Hours * 60 * 60) + (a.Minutes * 60) + a.Seconds;
            int total2 = (b.Hours * 60 * 60) + (b.Minutes * 60) + b.Seconds;
            if (total1 < total2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Boolean operator <=(Duration a, Duration b)
        {
            int total1 = (a.Hours * 60 * 60) + (a.Minutes * 60) + a.Seconds;
            int total2 = (b.Hours * 60 * 60) + (b.Minutes * 60) + b.Seconds;
            if (total1 <= total2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Boolean operator >=(Duration a, Duration b)
        {
            int total1 = (a.Hours * 60 * 60) + (a.Minutes * 60) + a.Seconds;
            int total2 = (b.Hours * 60 * 60) + (b.Minutes * 60) + b.Seconds;
            if (total1 >= total2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static explicit operator DateTime(Duration d)
        {
            return new DateTime();
        }
    }


    private static void Main(string[] args)
    {
        Duration D1 = new Duration(1, 10, 15);
        Console.WriteLine(D1.ToString());

        Duration D4 = new Duration(3600);
        Console.WriteLine(D4.ToString());

        Duration D2 = new Duration(7800);
        Console.WriteLine(D2.ToString());

        Duration D3 = new Duration(666);
        Console.WriteLine(D3.ToString());
        D3 = D1 + D2;
        D3 = D1 + 7800;
        D3 = 666 + D3;
        D3 = D1++;
        D3 = --D2;
        if (D1 > D2)
        {
            Console.WriteLine("D1 is greater");
        }
        else
        {
            Console.WriteLine("D2 is greater");
        }
        if (D1 <= D2)
        {
            Console.WriteLine("D2 is greater than or equal d1");
        }
        else
        {
            Console.WriteLine("D1 is greater");
        }
        Duration D5= new Duration(2,5,6);
        DateTime Obj = (DateTime) D5;



    }

}



   









