using System;

namespace My_Calculator_App
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3, num4, num5, num6, num7, num8, num9,a, b,c;

            Console.WriteLine("Addition");

            Console.Write("Enter a number:");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter another number:");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num1 + num2);

            Console.WriteLine("Subtraction");

            Console.Write("Enter a number:");
            num3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter another number:");
            num4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num3 - num4);

            Console.WriteLine("Multiplication");

            Console.Write("Enter a number:");
            num5 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter another number:");
            num6 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num5 * num6);

            Console.WriteLine("Division");

            Console.Write("Enter the numerator:");
            num7 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the denominator:");
            num8 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num7 / num8);

            Console.WriteLine("Exponential");

            Console.Write("Enter a number:");
            num9 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Exp(num9));

            Console.WriteLine("Quadratic Equation using formula method");

            Console.Write("Enter the value of b:");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the value of a:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the value of c:");
            c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(-b + Math.Sqrt(b*b -(4*a*c))/2*a );

           Console.WriteLine(-b - Math.Sqrt(b*b-(4*a*c)) / 2 * a);

            Console.ReadLine();
        }
    }
}
