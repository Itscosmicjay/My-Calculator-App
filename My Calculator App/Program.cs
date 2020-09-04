using System;

namespace My_Calculator_App
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3, num4, num5, num6, num7, num8, a, b, c;
            int num9, num10;

            Console.WriteLine("Addition");

            Console.Write("Enter a number:");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter another number:");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(Addition(num1, num2));

            Console.WriteLine("Subtraction");

            Console.Write("Enter a number:");
            num3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter another number:");
            num4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(Substraction(num3, num4));

            Console.WriteLine("Multiplication");

            Console.Write("Enter a number:");
            num5 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter another number:");
            num6 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(Multiplication(num5, num6));

            Console.WriteLine("Division");

            Console.Write("Enter the numerator:");
            num7 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the denominator:");
            num8 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(Division(num7, num8));

            Console.WriteLine("Exponential");

            Console.Write("Enter a number:");
            num9 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number:");
            num10 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Exponential(num9, num10));

            Console.WriteLine("Quadratic Equation using formula method");

            Console.Write("Enter the value of b:");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the value of a:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the value of c:");
            c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(FormularMethod(b, a, c));

            Console.WriteLine(FormularMethod(b, a, c));

            Console.ReadLine();
        }


        private static double Addition(double a, double b)
        {
            double answer = a + b;
            return answer;
        }
        private static double Substraction(double a, double b)
        {
            double answer = a - b;
            return answer;
        }
        private static double Multiplication(double a, double b)
        {
            double answer = a * b;
            return answer;
        }
        private static double Division(double a, double b)
        {
            double answer = a / b;
            return answer;
        }
        private static int Exponential(int a, int b)
        {
            int answer = a^b;
            return answer;
        }
        private static string FormularMethod(double b, double a , double c)
        {
            double answer = ((-b) + Math.Sqrt((b * b) - (4 * a * c) / (2 * a)));
            double answer1 = ((-b) - Math.Sqrt((b * b) - (4 * a * c) / (2 * a)));
            string Main = "x1 : " +answer + " x2 : " +answer1;
            return Main;
        }
    }
}

