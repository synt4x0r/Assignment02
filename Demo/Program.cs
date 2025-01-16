using System.Linq.Expressions;
using System.Text;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region string formatting
            // string Formatting
            // Eq : x + y = 12

            //int x = 3, y = 4;

            // 1. string concatantaion

            //string message = "Eq : " + x + " + " + y + " = " + (x + y);

            //Console.WriteLine(message);

            // string : Immutable datatype > cant change its value after creation

            // 2. string format

            //string message = string.Format("Eq : {0} + {1} + = {2}", x, y, x + y);

            //Console.WriteLine(message);

            // 2. string interpolution
            //$ > string manipulation

            //string message = $"Eq : {x} + {y} = {x + y}";

            //Console.WriteLine(message);
            // 
            #endregion

            #region control statement

            // conditional control statement (if statement, switch case)
            // loop control statement (for, foreach, while, do-while)

            //Console.WriteLine("hello world");
            //Console.WriteLine("hello world");
            //Console.WriteLine("hello world");


            // conditional control statement (if statement)

            //Console.Write("enter number of month in the 1st quarter : ");
            //int monum = int.Parse(Console.ReadLine());

            // 1 --> Jan
            // 2 --> Feb
            // 3 --> Mar


            //Console.WriteLine("Jan");
            //Console.WriteLine("Feb");
            //Console.WriteLine("Mar");

            //if (/*Expression*/)
            //{
            //    // code
            //    // this code will be executed when the condition is true
            //}


            //if (true)
            //{
            //    Console.WriteLine("hello world");

            //}

            // using if


            //while (true)
            //{
            //Console.Write("enter number of month in the 1st quarter : ");
            //int monum = int.Parse(Console.ReadLine());

            //if (monum == 1)
            //{
            //    Console.WriteLine("Jan");
            //}
            //if (monum == 2)
            //{
            //    Console.WriteLine("Feb");
            //}
            //if (monum == 3)
            //{
            //    Console.WriteLine("Mar");
            ////}




            // using switch

            //switch (/*Expression*/)
            //{
            //    case
            //}


            //while (true)
            //{
            //    Console.Write("enter number of month in the 1st quarter : ");
            //    int monum = int.Parse(Console.ReadLine());
            //    // jump table
            //    switch (monum)
            //    {
            //        case 1:
            //            Console.WriteLine("Jan");
            //            break;
            //        case 2:
            //            Console.WriteLine("Feb");
            //            break;
            //        case 3:
            //            Console.WriteLine("Mar");
            //            break;
            //        default:
            //            Console.WriteLine("invalid month number");
            //            break;
            //        case 5:
            //            Console.WriteLine("May");
            //            break;
            //    }
            //}
            #endregion

            #region ex01

            //Console.Write("enter your name: ");
            //string name = Console.ReadLine();

            //// hi name
            //if(name == "Ahmed" || name == "ahmed") // || >> means or
            //{
            //    Console.WriteLine("hi Ahmed");
            //}
            //else if (name == "Omar")
            //{
            //    Console.WriteLine("hi Omar");
            //}
            //else if (name == "Ali")
            //{
            //    Console.WriteLine("hi Ali");
            //}
            //else if (name == "Mariam")
            //{
            //    Console.WriteLine("hi Mariam");
            //}

            // using switch

            //Console.Write("enter your name: ");
            //string name = Console.ReadLine();

            //switch (name)
            //{
            //    case "Ahmed":
            //    case "ahmed":
            //        Console.WriteLine("hi Ahmed");
            //        break;
            //    case "Omar":
            //        Console.WriteLine("hi Omar");
            //        break;
            //    case "Ali":
            //        Console.WriteLine("hi Ali");
            //        break;
            //    case "Mariam":
            //        Console.WriteLine("hi Mariam");
            //        break;
            //}
            #endregion

            #region ex02
            //while (true)
            //{
            //    Console.Write("enter your age: ");
            //    int age = int.Parse(Console.ReadLine());

            //    //// using if

            //    //if (age > 18)
            //    //{
            //    //    Console.WriteLine("welcome :)");
            //    //}
            //    //else if (age < 18)
            //    //{
            //    //    Console.WriteLine("bye bye :(");
            //    //}
            //    //else
            //    //{
            //    //    Console.WriteLine("equal!!");
            //    //}

            //    //using switch

            //    switch (age)
            //    { 
            //        case > 18:
            //        Console.WriteLine("welcome");
            //            break;
            //        case < 18:
            //            Console.WriteLine("bye bye");
            //            break;
            //        default :
            //            Console.WriteLine("equal");
            //            break;
            //    }   
            //}
            #endregion

            #region evolution C#7

            //object obj = new object();
            //obj = "Ahmed";
            ////obj = 1;


            //switch (obj)
            //{
            //    case int X when X > -12:
            //        Console.WriteLine(value: "Int Object");
            //        break;
            //    case string X when X.Length > 5:
            //        Console.WriteLine(value: "string Object");
            //        break;
            //    case string X when X.Length <= 5:
            //        Console.WriteLine(value: "string Object <= 5");
            //        break;
            //}
            #endregion

            #region evolution C#8
            //string input = Console.ReadLine();
            //// 1
            //// 2
            //// 3
            ////string output = input switch
            ////{
            ////    "1" => "option 1",
            ////    "2" => "option 2",
            ////    "3" => "option 3",
            ////    _ => "Unsupported option!"
            ////};

            ////Console.WriteLine(output);



            //Console.WriteLine(input switch
            //{
            //    "1" => "option 1",
            //    "2" => "option 2",
            //    "3" => "option 3",
            //    _ => "Unsupported option!"
            //}); 
            #endregion

            #region loop control statement (for, foreach, while, do-while)
            // loop control statement (for, foreach, while, do-while)

            // 1. for loop

            //for (/*Statement >> one time*/; /*Expression >> if true >> repeat the code*/ ; /*Statement*/)
            //{
            //    // codee
            //    // that code will be repeated

            //}

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("hello world");
            //}

            // 2. foreach >> rotate on any container or collection

            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7 };

            ////for (int i = 0; i < Numbers.Length; i++)
            ////{
            ////    Console.WriteLine(Numbers[i]);
            ////}

            //foreach (int N in Numbers)
            //{
            //    Console.WriteLine(N);
            //}

            // 3. while

            //while (/*Expression >> bool*/)
            //{ 
            //    //code
            //    // code will be repeated while the expression is true
            //}

            //while ( true )
            //{
            //    Console.WriteLine("hello world");
            //}

            //int i = 1;

            //while (i <= 10)
            //{
            //    Console.WriteLine("hello world");
            //    i++;
            //}

            //Console.WriteLine(i);

            //do - while

            //do
            //{
            //    Console.WriteLine("hello world");
            //    i++;
            //} while (i <= 10);


            //int num;
            //bool flag;
            //do
            //{ 
            //    Console.Write("even number: ");
            //    //    flag = int.TryParse(Console.ReadLine(), out num);

            //    // while (num % 2 != 0 || flag == false);

            //} while (!int.TryParse(Console.ReadLine(), out num) || num % 2 != 0);

            //Console.WriteLine(num); 
            #endregion

            #region string
            // string : reference type : HEAP (class)
            // immutable type : cant change its value after creation

            //string S01;
            //// Declare For Reference (Pointer) From Type 'String' 
            //// S01 : Can Refer To Object From 'String'
            //// S01 : Refer To Null

            //// 8 Bytes Will Be Allocated At Stack For Refernce 'S01' 
            //// 0 Bytes Will Be Allocated At HEAP

            //S01 = "Ahmed"; // Syntax Sugar
            ////new
            //// 1. Allocate The Number Of Required Bytes For The Object At HEAP
            //// 2. Initialized The Allocated Bytes The Default Value
            //// 3.Call User-Defined Constructor If Exists
            //// 4. Assign The Object To The Reference
            //Console.WriteLine(S01.GetHashCode()); //ID : indicate address

            //S01 = "Ali";
            //// 1. Allocate The Number Of Required Bytes For The Object At HEAP
            //// 2. Initialized The Allocated Bytes The Default Value
            //// 3.Call User-Defined Constructor If Exists
            //// 4. Assign The Object To The Reference
            //Console.WriteLine(S01.GetHashCode());


            //S01 = "Yassmin";
            //Console.WriteLine(S01.GetHashCode());



            //string Message = "Hello";

            //Console.WriteLine("Message: " + Message); Console.WriteLine("HashCode: " + Message.GetHashCode());
            //Console.WriteLine();

            //Message += "Ahmed";

            //Console.WriteLine("Message : " + Message);
            //Console.WriteLine("HashCode : " + Message.GetHashCode()); 
            #endregion

            #region StringBuilder
            //// StringBuilder: Class (Reference Type) : HEAP
            //// Mutable Date Type : can change its value after creation

            //StringBuilder S01;
            ////// Declare For Reference (Pointer) From Type 'StringBuilder' 
            ////// S01 : Can Refer To Object From 'String'
            ////// S01 : Refer To Null

            //S01 = new StringBuilder("hello ");
            ////// 1. Allocate The Number Of Required Bytes For The Object At HEAP
            ////// 2. Initialized The Allocated Bytes The Default Value
            ////// 3.Call User-Defined Constructor If Exists
            ////// 4. Assign The Object To The Reference

            //Console.WriteLine("S01 : " + S01);
            //Console.WriteLine("S01HashCode : " + S01.GetHashCode);
            //Console.WriteLine();

            ////S01 = new StringBuilder("Ahmed");

            //S01.Append("Ahmed");

            //Console.WriteLine("S01 : " + S01);
            //Console.WriteLine("S01HashCode : " + S01.GetHashCode);
            //Console.WriteLine(); 
            #endregion

        }
    }
}
