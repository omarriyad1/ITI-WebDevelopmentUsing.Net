namespace D05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Inheritance
            //Point2D point2D = new Point2D();
            //point2D.Print();
            //point2D.X = 100;
            //point2D.Y = 200;
            //point2D.Print();

            //Console.WriteLine(point2D.Product());


            //Point3D point3D = new Point3D();
            //point3D.Print3D();
            //point3D.Print();

            //Console.WriteLine(point3D.Product()); 
            #endregion

            #region Methed Hidding VS Method Overriding ... Early Statically Vs late Dynamically  Binding
            //  Employee employee = new Employee();
            //  employee.Print();  // Parent Employee

            //  PartTiemEmp partTiemEmp = new PartTiemEmp();
            //  partTiemEmp.Print(); // Print Child PartTime

            // // Base Ref To Child,,, Drived
            ////Statically Binding,,, Early Binding
            //  Employee employee1 = new PartTiemEmp();
            //  employee1.Print(); // Parent Employee

            //  PartTiemEmp partTiemEmp1 = new PartTiemEmp();
            //  ((Employee)partTiemEmp1).Print(); // Parent Employee

            //  FullTimeEmp fullTimeEmp = new FullTimeEmp();
            //  fullTimeEmp.Print(); // Parent Employee using base Keyword

            //  //Dynamically Bindig ,,, Late Binding
            //  Employee employee2 = new CustEmp();
            //  employee2.Print(); // Print child cust time emp

            //  Employee employee3 = new EmptyEmp();
            //  employee3.Print(); 
            #endregion


            #region Method Overiing
            //Employee employee =  new Employee(1, "Ali", 500);
            //Employee employee1 = new Employee(2, "Hamada", 500);

            //Employee employee2 = employee; 

            ////Console.WriteLine(employee.ToString());

            ////Console.WriteLine(employee.Equals(employee1)); // Equal By Ref
            ////Console.WriteLine(employee.Equals(employee2));

            ////Console.WriteLine(employee.Equals(null));
            ////Console.WriteLine(employee.Equals(new Point2D() ));

            //PartTimeEmp partTimeEmp  = new PartTimeEmp();
            //Employee employee3 = new Employee();

            //Console.WriteLine(employee.Equals(partTimeEmp));
            //Console.WriteLine(employee3.Equals(partTimeEmp)); 
            #endregion

            /// Type of Classes 
            /// concrete Class ,,,       Create instance ,,,,,     Inheritance
            /// sealed   Class ,,,       Create instance  ,,,, Not Inheritance 
            /// Static   Class ,,,Cannot Create instance  ,,,, Not Inhritance
            /// Abstract Class ,,,Cannot Create instance  ,,,,     Inhritance 

            #region Static Class

            //int x = -5;
            //Console.WriteLine(Math.Abs(x));

            //Circle circle = new Circle(5);
            //// int radius = 5 ; 


            //Circle circle1 = new Circle(_radius: 3);           // double PI = 3.14 ; 
            //// int radius = 3 ; 



            //Circle circle2 = new Circle(4);
            // int radius = 4 ; 



            #endregion

            #region Abstract Class
            //  Instructor instructor = new Instructor(); // Abst class not vlaid to create obj 

            //PartTimeIns partTimeIns = new PartTimeIns();
            //Console.WriteLine(partTimeIns.PrinNum(5));

            //FullTimeIns fullTimeIns = new FullTimeIns();
            //Console.WriteLine(fullTimeIns.PrinNum(5));

            //Instructor instructor = new PartTimeIns();
            //instructor = new FullTimeIns();

            //Console.WriteLine(instructor.PrinNum(4));  
            #endregion

        }
    }
}