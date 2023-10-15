
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Xml.Linq;
using static Program;

internal class Program
{
public class Subject
{
    public int Code { get; set; }
    public string Name { get; set; }
       
}

public class Student
{
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Subject[] Subjects { get; set; }

        internal static IEnumerable<object> SelectMany(Func<object, object> value1, Func<object, object, object> value2)
        {
            throw new NotImplementedException();
        }
    }
private static void Main(string[] args)
    {
        //Q1-Query1
        Console.WriteLine("Q1-Query1");
        Console.WriteLine("------------");
        List<int> numbers = new List<int>() { 2, 4, 6, 7, 1, 4, 2, 9, 1 };
        var filterednumber = numbers.OrderBy(x => x).Distinct();
        foreach (var number in filterednumber)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine("--------------------------------------");
        //Q1-Query2
        Console.WriteLine("Q1-Query2");
        Console.WriteLine("------------");
        var multipledlist = filterednumber.Select(x => new {number=x,Multiply=x*x});
        foreach (var number in multipledlist)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine("--------------------------------------");
        //Q2-Query1
        Console.WriteLine("Q2-Query1");
        Console.WriteLine("------------");
        string[] names = { "Tom", "Dick", "Harry", "MARY", "Jay" };
        var filterdnames= names.Where(x=>x.Length==3);
        foreach (var filter in filterdnames)
        {
            Console.WriteLine(filter);
        }
        Console.WriteLine("--------------------------------------");
        //Q2-Query2
        Console.WriteLine("Q2-Query2");
        Console.WriteLine("------------");
        var filterdnames2 = names.Where(x => x.Contains("a") || x.Contains("A")).OrderBy(x=>x.Length);
        foreach (var filter in filterdnames2)
        {
            Console.WriteLine(filter);
        }
        Console.WriteLine("--------------------------------------");
        //Q2-Query3
        Console.WriteLine("Q2-Query3");
        Console.WriteLine("------------");
        var filterdnames3 = names.Take(2);
        foreach (var filter in filterdnames3)
        {
            Console.WriteLine(filter);
        }
        Console.WriteLine("--------------------------------------");
        //Q3
        Console.WriteLine("Q3");
        Console.WriteLine("-----");
        List<Student> students = new List<Student>(){
 new Student(){ ID=1, FirstName="Ali", LastName="Mohammed",
Subjects=new Subject[]{ new Subject(){ Code=22,Name="EF"}, new Subject(){
Code=33,Name="UML"}}},
 new Student(){ ID=2, FirstName="Mona", LastName="Gala",
Subjects=new Subject []{ new Subject(){ Code=22,Name="EF"}, new Subject (){
Code=34,Name="XML"},new Subject (){ Code=25, Name="JS"}}}, new
Student(){ ID=3, FirstName="Yara", LastName="Yousf", Subjects=new Subject
[]{ new Subject (){ Code=22,Name="EF"}, new Subject (){
Code=25,Name="JS"}}},
 new Student(){ ID=1, FirstName="Ali", LastName="Ali",
Subjects=new Subject []{ new Subject (){ Code=33,Name="UML"}}},

 };
        //Q3-Query1
        Console.WriteLine("Q3-Query1");
        Console.WriteLine("------------");
        var filtered= students.Select(x => new { fullname =x.FirstName+x.LastName,NoOfSubjects=x.Subjects.Length});
        foreach(var x in filtered)
        {
            Console.WriteLine(x);
        }
        //Q3-Query2
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Q3-Query2");
        Console.WriteLine("------------");
        var filtered2 = students.OrderByDescending(x => x.FirstName).ThenBy(x=>x.LastName);
        foreach (var ff in filtered2)
        {
            Console.Write(ff.FirstName);
            Console.WriteLine(    ff.LastName);
        }
        //Q3-Query3
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Q3-Query3");
        Console.WriteLine("------------"); 
        var filtered8 = students
            .SelectMany(
                student => student.Subjects,
                (student, subject) => new { StudentName = $"{student.FirstName} {student.LastName}", subject.Name }
            );

        foreach (var ff in filtered8)
        {
            Console.WriteLine($"Student Name: {ff.StudentName}, Subject Name: {ff.Name}");
        }



        //Q3-Query4(Bouns)
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Q3-Query4 ");
        Console.WriteLine("------------");
        var filtered9 = students
            .SelectMany(student => student.Subjects, (student, subject) => new { FullName=student.FirstName+student.LastName, subject.Name })
            .GroupBy(x => x.FullName);

        foreach (var group in filtered9)
        {
            string fullName = group.Key;
            foreach (var item in group)
            {
                Console.WriteLine(fullName);
                Console.WriteLine(item.Name);
            }
        }

    }

}
    
