using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D05
{
    internal  class Employee 
    {
        private int id;
        string name;
        decimal salary;

        public Employee()
        {


        }

        public Employee(int _id , string _name , decimal _salary)
        {
            id = _id; 
            name = _name;
            salary = _salary;
        }

        public override string ToString()
        {
            return $"ID :: {id }  Name :: {name} Salary :: {salary}";
        }

        public override bool Equals(object? obj)
        {
            //Employee right =(Employee) obj; // casting unsafe

            //return salary == right.salary;

            //Problems
            // 1- Null 
            // 2- Unsafe Casting

            #region is

            // is keyword return true if casting successfully , return false casting faild


            //if (obj is Employee right)
            //    return salary == right.salary;

            //return false;
            #endregion

            #region as
            // as keywoed return null if casting faild ,,, success return obj casting (Employee)
            if (GetType() != obj?.GetType()) return false;

            Employee right = obj as Employee;

            if (this == right) return true;

            return salary == right?.salary && id == right?.id && name == right?.name;
            #endregion
        }


    }

    class PartTimeEmp : Employee
    {

    }
}
