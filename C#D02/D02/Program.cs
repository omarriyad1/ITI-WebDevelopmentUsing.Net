namespace D02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Refrence Type object ... String
            //object o1 = new object();

            //Console.WriteLine(o1.GetHashCode());

            //object o2 = new object();
            //Console.WriteLine(o2.GetHashCode());

            //o2 = o1;
            //Console.WriteLine("After =");
            //Console.WriteLine(o1.GetHashCode());
            //Console.WriteLine(o2.GetHashCode());

            //string s = null;
            //Console.WriteLine(s);
            //Console.WriteLine(s.GetHashCode());

            //string str = string.Empty;
            ////string str1 = string.Empty;
            ////string str2 = ""; 

            ////str = "hamada";
            ////Console.WriteLine(str.GetHashCode());
            ////Console.WriteLine(str1.GetHashCode());
            ////Console.WriteLine(str2.GetHashCode());

            //string name = "Hamada";
            //string address = "cairo";

            //name::
            //name:: Haamda
            //name:: Haamda address::
            //name:: Haamda address:: cairo 


            //Console.WriteLine("Name:: "+ name + "address:: " + address);
            //Console.WriteLine($"Name::  {name}  address::  {address}"); 
            #endregion

            #region Terrnary Operator
            //int x = 5;
            //int y = 4;

            //if(y>x)
            //{
            //    y = 10;
            //    Console.WriteLine(y);
            //}
            //else
            //{
            //    y = 20;
            //    Console.WriteLine(y);
            //}

            // Terrnaty operator 
            // assign condition ? true : false 

            //y = y > x ? 10 : 20;
            //Console.WriteLine(y);
            #endregion

            #region Bool
            //int x = 5;
            //int y = 10;
            //bool b = true;

            //bool m = y > x;

            //b = default(bool);
            //b = default;


            #endregion

            #region String
            //string str = "III";
            //str = null;
            //string str2 = "Hamada"; 
            //if(str != null)
            //Console.WriteLine(str.Length);

            //Console.WriteLine(str?.Length ?? -1);

            //Console.WriteLine(str?.Length ?? -1);

            //str = str ?? str2;

            //Console.WriteLine(str.Length);
            #endregion

            #region Casting
            #region Implicit Casting ,,, Explicit casting

            // int = Int32 
            // long = Int64
            //int x = 50;
            //long y = 5;

            //y = x; // implicit casting no use of casting operation 
            //y = long.MaxValue;

            //x = (int)y; // explicit castion use dataType castion operation
            //Console.WriteLine(x);

            //checked
            //{
            //    unchecked
            //    {
            //         x = (int)y;

            //    }
            //    //int z = (int)y; 
            //} 
            #endregion

            #region Boxing ... UnBoxing
            //object o1; // Parent // instance created in heap 

            //int x = 5;  // created in stack 

            //o1 = x; // Boxing  Safe // not use it  

            //object o2 = new object();

            //o2 = x;

            //x = (int)o2; // Unboxing unsafe

            //o2 = "string";
            //o2 = null;
            //o2 = long.MaxValue;
            //o2 = default(bool); 

            //x = (int)o2; // Unboxing unsafe Handle Exc

            #endregion
            #endregion

            #region Console ReadLine
            //string str = "Hello";
            //str = "55";

            //int x;
            ////x = (string)str; // Invalid
            //x = int.Parse(str); // unsafe handle ex 

            //Console.WriteLine("Please Enter your name");
            //string name =  Console.ReadLine();

            //Console.WriteLine("Please Enter your age");
            //string age = Console.ReadLine();
            //int ageInt = int.Parse(age);
            //ageInt++;

            //Console.WriteLine($"Name is {name} Age is {ageInt}");
            //int salary = int.Parse( Console.ReadLine()); 
            #endregion

            #region Array 
            // int x = 5;
            // int y = 10;
            // int z = 30;

            // int[] Arr;
            // //Reference to int Arr 
            // // Zero Bytes have been Allocated in heap  

            // Arr = new int[3]; 
            // Arr = new int[3] {10 , 20 , 30};

            // int[] Arr2 = new int[] { 1, 2, 6 }; // Intialzer
            // int[] Arr3 = { 1, 2, 3, 4, 5 };// in IL sme to line 173

            // int[] arr = new int[3];

            // arr[0] = 100; // [0] --> Index // Element 1 
            // arr[1] = 200; // [1] --> Index // Element 2
            // arr[2] = 300; // [2] --> Index // Element 3 

            //// arr[3] = 400; // Invalid Throw Ex Out of rang must x handle ex
            // Console.WriteLine(arr[0]);


            // int xx = arr[0];
            // Console.WriteLine(xx);

            // Console.WriteLine(arr.Length);
            // Console.WriteLine(arr.Rank);

            //            0  1  2  3  4
            //int[] arr = { 1, 2, 3, 4, 5 };
            //int[] arr2 = { 100, 200 };


            //Console.WriteLine(arr?.GetHashCode());
            //Console.WriteLine(arr2?.GetHashCode());

            //arr2 = arr;  // Sharing the same identity and same state 

            //Console.WriteLine("-------------");
            //Console.WriteLine(arr?.GetHashCode());
            //Console.WriteLine(arr2?.GetHashCode());

            //arr2[2] = 5000;
            //Console.WriteLine(arr[2]);


            //// Foreach slower than for 
            //// For Printing Only 
            //foreach (int item in arr2)
            //{
            //    //item++;  // Invalid 
            //    Console.WriteLine(item);    
            //}

            //for (int i = 0; i < arr2?.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}


            //int[] arr = { 1, 2, 3, 4, 5 };
            //int[] arr2 = { 1, 2 };

            //Console.WriteLine(arr.GetHashCode());
            //Console.WriteLine(arr2.GetHashCode());

            //arr2 = arr; // sharing the same state ,,, same identity
            //Console.WriteLine(arr.GetHashCode());
            //Console.WriteLine(arr2.GetHashCode());

            //// same state with different identity
            //int[] arr3 = (int[]) arr.Clone();

            //foreach (var item in arr3)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(arr.GetHashCode());
            //Console.WriteLine(arr3.GetHashCode());
            #endregion

            #region Two D Array
            //int[,] marks = new int[3, 5]; //[row ,col]
            //int[,] marks2 = new int[3, 5]
            //{
            //    {1,2,3,4,5 },
            //    {10,20,30,40,50 },
            //    {100,200,300,400,500 }
            //};

            //Console.WriteLine(marks2.Length);  //row * col
            //Console.WriteLine(marks2.Rank);

            //for (int r = 0; r < marks2.GetLength(0); r++)
            //{
            //    for (int c = 0; c < marks2.GetLength(1); c++)
            //    {
            //        Console.WriteLine(marks2[r,c]);
            //    }
            //}
            #endregion

            #region Nullable Types

            //object o1 = null;
            //string str = null;
            //int[] arr = null;

            //int x = null; // not valid int Numbers Onl 
            //bool b = null; // not valid boot true or flase only

            //Nullable Types (value type )

            //Nullable<int>  x = null;
            //Nullable<bool> b = null;


            //Nullable<int> number == int? number ;
            //bool? booleanVar = null; 

            //int? z = null;

            //int  x = 5 ; // small
            //int? y = null;  // big 

            //y = x; // safe Implicit castiong

            //x = (int)y; /// Unsafe Explicit Casting
            
            //if(y.HasValue)
            //    Console.WriteLine(y.Value);
            //else
            //    Console.WriteLine("NA");
            #endregion
        }
    }
}