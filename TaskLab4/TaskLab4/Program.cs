using System.Drawing;
using System.Reflection;

internal class Program
{
    class Employee
    {
        private string First_Name;
        private string Last_Name;
        private decimal Salary;
        private string Address;
        private int Age;
        private Gender _gender;
        public Gender gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        
        public void SetFName(String fff)
        {
            First_Name = fff;
        }
        public void SetLName(String sss)
        {
            Last_Name = sss;
        }
        public string GetName()
        {
            return First_Name+ " "+Last_Name;
        }
        public void SetAddress(string ll)
        { Address = ll; }
        public string GetAddress()
        {
            return Address;
        }
        public void SetAge(int age)
        { Age = age; }
        public int GetAge()
        {
            return Age;
        }
        public void SetSalary(decimal mn)
        {
            Salary = mn;
        }
        public decimal GetSalary()
        {
            return Salary;
        }
        public Employee()
        {

        }
        public Employee(string fn, string ln, int ss, string ad, int ag, Gender gen)
        {
            First_Name = fn;
            Last_Name = ln;
            Salary = ss;
            Address = ad;
            Age = ag;
            gender = gen;
        }




    }
    public enum Gender {
        Male,
        Female }

    private static void Main(string[] args)
    {
        Console.Write("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());
        Employee[] emp = new Employee[size];
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"Enter details for employee {i + 1}:");
            Employee employee = new Employee();

            Console.Write("Enter First Name: ");
            string fn;
            fn = Console.ReadLine();
            employee.SetFName(fn);
            while (string.IsNullOrEmpty(fn))
            {
                    Console.Write("you must Enter First Name: ");
                    fn = Console.ReadLine();
                    employee.SetFName(fn);
                if(!string.IsNullOrEmpty(fn))
                {
                    continue;
                }
            }

        
           
           

            Console.Write("Last Name: ");
            string ln ;
            Console.Write("Enter Last Name: ");
             ln = Console.ReadLine();
            employee.SetLName(ln);
            while (string.IsNullOrEmpty(ln))
            {
                    Console.Write("you must enter your lname ");
                    ln = Console.ReadLine();
                    employee.SetLName(ln);
                if (!string.IsNullOrEmpty(ln))
                {
                    continue;
                }

            }
            
            decimal sal=0;
            Console.Write("Salary: ");
           sal= Convert.ToDecimal(Console.ReadLine());
            while(sal <=900)
            {
                Console.Write("Salary Should be more than 900 ");
                Console.WriteLine("Enter your Salary");
                sal=Convert.ToDecimal(Console.ReadLine());
                if (sal > 900)
                {
                    employee.SetSalary(sal);
                    continue;

                }
            }
            
            
            Console.Write("Address: ");
             String add= Console.ReadLine();
            employee.SetAddress(add);
            int age=0;
            Console.Write("Age: ");
            age = Convert.ToInt32(Console.ReadLine());
            while (age <= 20)
            {
                Console.Write("your Age should n=be greater than 20 ");
                Console.Write("Age: ");
                age = Convert.ToInt32(Console.ReadLine());
                if (age > 20)
                {
                    employee.SetAge(age);
                    continue;
                }
            }
               
           
            
            
            foreach (Gender gender in Enum.GetValues(typeof(Gender)))
            {
                Console.WriteLine(gender);
            }
            Console.Write("Gender (0 for Male, 1 for Female): ");
            employee.gender = (Gender)Convert.ToInt32(Console.ReadLine());
            emp[i] = employee;
        }
        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine("Employee Details:");
        for(int i =0;i<emp.Length;i++)
        {
            Console.WriteLine($"Name: {emp[i].GetName()} ");
            Console.WriteLine($"Salary: {emp[i].GetSalary()}");
            Console.WriteLine($"Address: {emp[i].GetAddress()}");
            Console.WriteLine($"Age: {emp[i].GetAge()}");
            Console.WriteLine($"Gender: {emp[i].gender}");
            Console.WriteLine();
        }

    }
}
