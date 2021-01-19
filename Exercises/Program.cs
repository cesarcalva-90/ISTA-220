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
            Console.WriteLine("\nPart 1 , circumference and area of a circle.");
            Console.Write("Enter an integer for the radius:");
            string strradius = Console.ReadLine();
            int intradius = int.Parse(strradius);
            double circumference = intradius * 2 * Math.PI;
            Console.WriteLine($"The circumference is { circumference }");
            double area = Math.Pow(intradius,2) * Math.PI;
            Console.WriteLine($"The area is {area}");

            Console.WriteLine("\nPart 2 , volume of a hemisphere.");
            Console.Write("Enter an integer for the radius:");
            strradius = Console.ReadLine();
            intradius = int.Parse(strradius);
            double volume = (4.0 / 3.0 * Math.PI * Math.Pow(intradius,3))/2;
            Console.WriteLine($"The volume is {volume}");

            Console.WriteLine("\nPart 3 , area of a triangle (Heron's formula).");
            Console.Write("Enter 3 integers for the 3 sides of the trinagle: \n");
            string strA = Console.ReadLine();
            string strB = Console.ReadLine();
            string strC = Console.ReadLine();
            int intA = int.Parse(strA);
            int intB = int.Parse(strB);
            int intC = int.Parse(strC);
            int p = (intA + intB + intC) / 2;
            area = Math.Sqrt(p*(p-intA)*(p-intB)*(p-intC));
            Console.WriteLine($"The area is {area}");

            Console.WriteLine("\nPart 4 , solving a quadratic equation.");
            Console.Write("for the quadratic equation Ax^2 + Bx + C = 0, give the parameters for A, B and C in that order: \n");
            strA = Console.ReadLine();
            strB = Console.ReadLine();
            strC = Console.ReadLine();
            double doubleA = double.Parse(strA);
            double doubleB = double.Parse(strB);
            double doubleC = double.Parse(strC);
            double positive_num = Math.Sqrt(Math.Pow(doubleB, 2) - (4 * doubleA * doubleC));
            double negative_num = (Math.Sqrt(Math.Pow(doubleB, 2) - (4 * doubleA * doubleC))) * -1;
            double denominator = 2 * doubleA;
            double x1 = ((-1 * doubleB) + positive_num) / denominator;
            double x2 = ((-1 * doubleB) + negative_num) / denominator;
            Console.WriteLine($"x1 and x2 are respectively: \n {x1} \n {x2}");
        }
    }
}
