using System;

namespace My_Calculator_App
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num9, num10, userInput;

            Console.WriteLine("What operations do you want to carry out");

            Console.Write("1:Addition 2:Subtraction 3:Multiplication 4:DIvision 5:Exponential 6:Quadratic eqution(formula method):");
            userInput= Convert.ToInt32(Console.ReadLine());


            if (userInput == 1)

            {
                Addition();
            }
            else if (userInput == 2)

            {
                Substraction();
            }
            else if (userInput == 3)

            {
                Multiplication();
            }
            else if (userInput == 4)

            {
                Division();
            }
            else if (userInput == 5)

            {
                Exponential();
            }
            else if (userInput == 6)

            {
            FormularMethod();
            }
            else
            {
                Console.WriteLine("Please select one of the options");
            }

            Console.ReadLine();
        }


        private static void Addition()
        {
            double a, b;
            Console.Write("Enter a number:");
            a= Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter another number:");
            b = Convert.ToDouble(Console.ReadLine());

            double answer = a + b;
            console.WriteLine(answer);
            
        }
        private static void Substraction()
        {
            double a, b;
            Console.Write("Enter a number:");
            a= Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter another number:");
            b = Convert.ToDouble(Console.ReadLine());
            double answer = a - b;
            console.WriteLine(answer);
        }
        private static void Multiplication()
        {
            double a, b;
            Console.Write("Enter a number:");
            a= Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter another number:");
            b = Convert.ToDouble(Console.ReadLine());
            double answer = a * b;
            console.WriteLine(answer);
        }
        private static void Division()
        {
            double a, b;
            Console.Write("Enter a number:");
            a= Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter another number:");
            b = Convert.ToDouble(Console.ReadLine());
            double answer = a / b;
            console.WriteLine(answer);
        }
        private static void Exponential()
        {
            int a, b;
            Console.Write("Enter a number:");
            a= Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter another number:");
            b = Convert.ToDouble(Console.ReadLine());
            int answer = a^b;
            console.WriteLine(answer);
        }
        private static void FormularMethod()
        {
            double a, b, c;
            Console.Write("b:");
                b = Convert.ToDouble(Console.ReadLine());

                Console.Write("a:");
                a = Convert.ToDouble(Console.ReadLine());

                Console.Write("c:");
                c = Convert.ToDouble(Console.ReadLine());
            double answer = ((-b) + Math.Sqrt((b * b) - (4 * a * c) / (2 * a)));
            double answer1 = ((-b) - Math.Sqrt((b * b) - (4 * a * c) / (2 * a)));
            string Main = "x1 : " +answer + " x2 : " +answer1;
           console.WriteLine(Main);
        }
    } 
}

