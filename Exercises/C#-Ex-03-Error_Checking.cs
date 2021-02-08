using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Exercise_01_Cesar_Calva
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            do
            {
                try
                {
                    Console.WriteLine("\nPart 1 , circumference and area of a circle.");
                    Console.Write("Enter an integer for the radius:");
                    double intradius = getnumber();
                    double circumference = intradius * 2 * Math.PI;
                    Console.WriteLine($"The circumference is { circumference }");
                    double area = Math.Pow(intradius, 2) * Math.PI;
                    Console.WriteLine($"The area is {area}");
                    exit = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Not an Integer");
                }
                catch (Exception)
                {
                    Console.WriteLine("Must be Positive Integer");
                }
                finally
                {
                    Console.WriteLine("Okay");
                }
            } while (!exit);

            exit = false;
            do 
            {
                try
                {
                    Console.WriteLine("\nPart 2 , volume of a hemisphere.");
                    Console.Write("Enter an integer for the radius:");
                    double intradius = getnumber();
                    double volume = (4.0 / 3.0 * Math.PI * Math.Pow(intradius, 3)) / 2;
                    Console.WriteLine($"The volume is {volume}");
                    exit = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Not an Integer");
                }
                catch (Exception)
                {
                    Console.WriteLine("Must be Positive Integer");
                }
                finally
                {
                    Console.WriteLine("Okay");
                }
            } while (!exit);

            exit = false;
            do
            {
                try
                {
                    Console.WriteLine("\nPart 3 , area of a triangle (Heron's formula).");
                    Console.Write("Enter 3 integers for the 3 sides of the trinagle: \n");
                    double intA = getnumber();
                    double intB = getnumber();
                    double intC = getnumber();
                    double p = (intA + intB + intC) / 2;
                    double area = Math.Sqrt(p * (p - intA) * (p - intB) * (p - intC));
                    Console.WriteLine($"The area is {area}");
                    exit = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Not an Integer");
                }
                catch (Exception)
                {
                    Console.WriteLine("Must be Positive Integer");
                }
                finally
                {
                    Console.WriteLine("Okay");
                }
            } while (!exit);

            exit = false;
            do
            {
                try
                {
                    Console.WriteLine("\nPart 4 , solving a quadratic equation.");
                    Console.Write("for the quadratic equation Ax^2 + Bx + C = 0, give the parameters for A, B and C in that order: \n");
                    double doubleA = getnumber("Allow Negative");
                    double doubleB = getnumber("Allow Negative");
                    double doubleC = getnumber("Allow Negative");
                    double positive_num = Math.Sqrt(Math.Pow(doubleB, 2) - (4 * doubleA * doubleC));
                    double negative_num = (Math.Sqrt(Math.Pow(doubleB, 2) - (4 * doubleA * doubleC))) * -1;
                    double denominator = 2 * doubleA;
                    double x1 = ((-1 * doubleB) + positive_num) / denominator;
                    double x2 = ((-1 * doubleB) + negative_num) / denominator;
                    Console.WriteLine($"x1 and x2 are respectively: \n {x1} \n {x2}");
                    exit = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Not an Integer");
                }
                finally
                {
                    Console.WriteLine("Okay");
                }
            } while (!exit);
        }

        private static double getnumber(string allownegative = "Deny Negative" )
        {
            if (allownegative == "Allow Negative")
            {
                Console.WriteLine("Enter integer: ");
                string snumber = Console.ReadLine();
                double inumber = double.Parse(snumber);
                return inumber;
            }                
            else
            {
                Console.WriteLine("Enter positive integer: ");
                string snumber = Console.ReadLine();
                double inumber = double.Parse(snumber);
                if (inumber < 0)
                {
                    throw new Exception();
                }
                return inumber;
            }                
        }
    }
}
