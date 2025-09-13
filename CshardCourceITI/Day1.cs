
using CshardCourceITI;

namespace D1CSharp
{
    internal class Day1
    {
        public static void ASCII(char c)
        {
            Console.WriteLine("Character: " + c);
            Console.WriteLine("ASCII code: " + (int)c);
        }
        public static void UnASCII(int c)
        {
            Console.WriteLine("ASCII code: " + c);
            Console.WriteLine("Character: " + (char)c);
        }
        public static bool is_Even(int i)
        {
            return(i%2==0);
        }
        public static void Calc(int a, int b)
        {
            char c;
            Console.Write("Enter op (+ , - , * , /): ");
            c = Convert.ToChar(Console.Read());
            switch (c)
            {
                case '+':
                    Console.WriteLine(a + b);
                    break;

                case '-':
                    Console.WriteLine(a - b);
                    break;

                case '*':
                    Console.WriteLine(a * b);
                    break;

                case '/':
                    Console.WriteLine(a / b);
                    break;

                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }
        }
        public static void grade(int d)
        {
            if (d >= 90)
            {
                Console.WriteLine("Student got A");
            }
            else if (d >= 80 && d < 90)
            {
                Console.WriteLine("Student got B");
            }
            else if (d >= 70 && d < 80)
            {
                Console.WriteLine("Student got C");
            }
            else if (d >= 60 && d < 70)
            {
                Console.WriteLine("Student got D");
            }
            else
            {
                Console.WriteLine("Student has failed.");
            }
        }
        public static void multiTable()
        {
            int num = 0;
            for(int i = 1; i < 13; i++)
            {
                Console.WriteLine("Table of: " + i);
                Console.WriteLine("-----------------");
                for (int j = 1; j < 13; j++)
                {
                    num = i * j;
                    Console.WriteLine(i + " * " + j + " = " + num);
                }
                Console.WriteLine("\n-----------------");
            }    
        }
        static void Main(string[] args)
        {
            Console.WriteLine("sum: " + calc.Sum(1, 2));
            Console.WriteLine("sum: " + calc.Sum(3, 4));
            Console.WriteLine("sum: " + calc.Sum(5, 6));
            Console.WriteLine("sum: " + calc.Sum(7, 8));

            Question q1 = new Question("Q1", "What is 2 + 2", 2);
            q1.Show();

            Console.WriteLine();

            MCQquestion mcq = new MCQquestion("MCQ Question", "Which  is the programming language?", 3, new string[] { "HTML", "C++", "CSS", "XML" });
            mcq.Show();

            Console.ReadKey();
        }
    }
}