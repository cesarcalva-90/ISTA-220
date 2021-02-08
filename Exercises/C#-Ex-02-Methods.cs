using System;

namespace Exercise02Cesar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter ten numbers one at the time (0-100): ");
            int start = 1;
            int end = 10;
            int sum = 0;
            sum = get_sum(start, end, sum);
            Console.WriteLine($"The sum is {sum}");

            Console.WriteLine("please enter final grade:");
            string gradestr = Console.ReadLine();           
            int gradeint = Int32.Parse(gradestr);
            string grade = get_grade(gradeint);
            Console.WriteLine($"The grade is {grade}");

            Console.WriteLine("please enter ten numbers one at the time (0-100): ");
            start = 1;
            end = 10;
            sum = 0;
            sum = get_sum(start, end, sum);
            int average = sum / end;
            grade = get_grade(average);
            Console.WriteLine($"The sum is {sum}");
            Console.WriteLine($"The average is {average}");
            Console.WriteLine($"The grade is {grade}");

            Console.WriteLine("How many tests?:");
            string numteststr = Console.ReadLine();
            end = Int32.Parse(numteststr); 
            start = 1;
            sum = 0;
            sum = get_sum(start, end, sum);
            average = sum / end;
            grade = get_grade(average);
            Console.WriteLine($"The sum is {sum}");
            Console.WriteLine($"The average is {average}");
            Console.WriteLine($"The grade is {grade}");

            start = 1;
            sum = 0;
            (start, sum) = get_sum_indef(start, sum);
            average = (sum + 1) / (start - 2);
            Console.WriteLine($"The average is {average}");
            grade = get_grade(average);
            Console.WriteLine($"The grade is {grade}");
        }

        private static (int, int) get_sum_indef(int start, int sum)
        {
            Console.WriteLine($"start {start}, sum {sum}, input -1 to stop grades :");
            string numberstr = Console.ReadLine();
            int numberint = Int32.Parse(numberstr);
            sum = sum + numberint;
            start = start + 1;
            if (numberint > 0)
                return get_sum_indef(start, sum);
            else
                return (start, sum);
        }

        private static string get_grade(int average)
        {
            string grade = "Grade";
            if (average >= 90)
                return (grade = "A");
            else if(average >= 80)
                return (grade = "B");
            else if (average >= 70)
                return (grade = "C");
            else if (average >= 60)
                return (grade = "D");
            else
                return (grade = "F");
        }

        private static int get_sum(int start, int end, int sum)
        {
            Console.WriteLine($"start {start}, end {end}, sum {sum}");
            string number = Console.ReadLine();
            int suminput = Int32.Parse(number);
            sum = sum + suminput;
            start = start + 1; 
            if (start <= end )
                return get_sum(start, end, sum);
            else
                return (sum);
        }
    }
}
