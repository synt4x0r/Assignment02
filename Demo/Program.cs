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

            
            while (true)
            {
                Console.Write("enter number of month in the 1st quarter : ");
                int monum = int.Parse(Console.ReadLine());
                // jump table
                switch (monum)
                {
                    case 1:
                        Console.WriteLine("Jan");
                        break;
                    case 2:
                        Console.WriteLine("Feb");
                        break;
                    case 3:
                        Console.WriteLine("Mar");
                        break;
                    default:
                        Console.WriteLine("invalid month number");
                        break;
                    case 5:
                        Console.WriteLine("May");
                        break;
                }
            }










            #endregion
        }
    }
}
