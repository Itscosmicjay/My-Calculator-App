using System;

namespace My_Calculator_App
{
    class Program
    {
        static void Main(string[] args)
        {
            double  num3, num4, num5, num6, num7, num8, a, b, c;
            int num9, num10, num0;
            Console.WriteLine("What operations do you want to carry out");

            Console.Write("1:Addition 2:Subtraction 3:Multiplication 4:DIvision 5:Exponential 6:Quadratic eqution(formula method):");
            num0= Convert.ToInt32(Console.ReadLine());

            if (num0 == 1)
            {
                Console.WriteLine(Addition(a, b));
            }
            else if (num0 == 2)
            {
                Console.Write("Enter a number:");
                num3 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter another number:");
                num4 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(Substraction(num3, num4));
            }
            else if (num0 == 3)
            {
                Console.Write("Enter a number:");
                num5 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter another number:");
                num6 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(Multiplication(num5, num6));
            }
            else if (num0 == 4)
            {
                Console.Write("Enter the numerator:");
                num7 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the denominator:");
                num8 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(Division(num7, num8));
            }
            else if (num0 == 5)
            {
                Console.Write("Enter a number:");
                num9 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter another number:");
                num10 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(Exponential(num9, num10));
            }
            else if (num0 == 6)
            {
                Console.Write("b:");
                b = Convert.ToDouble(Console.ReadLine());

                Console.Write("a:");
                a = Convert.ToDouble(Console.ReadLine());

                Console.Write("c:");
                c = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(FormularMethod(b, a, c));

                Console.WriteLine(FormularMethod(b, a, c));
            }
            else
            {
                Console.WriteLine("Please select one of the options");
            }


            

 
            Console.ReadLine();
        }


        private static double Addition(double a, double b)
        {
            Console.Write("Enter a number:");
            a= Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter another number:");
            b = Convert.ToDouble(Console.ReadLine());

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

