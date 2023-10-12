/////OOP
///// Abstraction , Encapsulation , Inheritance , Polymerphism


///// Access Modifer
///// Private access only on the same class
///// Protected access on inheritance class level 
///// Internal acces on the same project ,,, same assemly file 
///// Pulic access for any one ,,, any place 


//namespace D05
//{
//     // Base Class
//     // Parent Class 
//    internal class Employee
//    {

//        public virtual void Print() => Console.WriteLine("Parent Employee");

//        // Method Overloading
//        public int Sum (int x , int y) => x + y;

//        public int Sum(int x, int y, int z) => x + y + z;

//        public string Sum(string x, int y) => $"{x} , {y}"; 

//    }

//    class PartTiemEmp : Employee
//    {
//        // Method Hiding

//        public new  void Print() => Console.WriteLine("Part Time Employee");
//    }

//    class FullTimeEmp :Employee
//    {
//        public new void Print()
//        {
//            base.Print();
//            Console.WriteLine("Full Time  Employee");
//        }

//    }

//    class CustEmp :Employee
//    {
//        // method overriding
//        public override void Print()
//        {
//            Console.WriteLine("Cust Time  Employee");
//        }

//    }

//    class EmptyEmp : Employee
//    {

//    }
//}
