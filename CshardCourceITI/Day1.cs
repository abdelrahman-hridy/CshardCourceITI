
using System.Drawing;
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
            Company company = new Company { Name = "Tech Corp" };
            Department it = new Department { Name = "IT" };
            Department hr = new Department { Name = "HR" };
            company.departments.Add(it);
            company.departments.Add(hr);

            Employee e1 = new Employee("Alice", 28);
            Employee e2 = new Employee("Bob", 30);
            it.employees.Add(e1);
            hr.employees.Add(e2);

            Instructor inst1 = new Instructor("Dr. Smith", 45);
            Instructor inst2 = new Instructor("Prof. John", 50);

            Course c1 = new Course("C# Basics", CourseLevel.Beginner);
            Course c2 = new Course("OOP Advanced", CourseLevel.Advanced);

            inst1.TeachCourse(c1);
            inst2.TeachCourse(c2);

            Student s1 = new Student("Charlie", 20, 1);
            Student s2 = new Student("Diana", 22, 2);

            s1.RegisterCourse(c1);
            s1.RegisterCourse(c2);
            s2.RegisterCourse(c1);

            s1.Grades.Add(new Grade(90));
            s1.Grades.Add(new Grade(85));
            s2.Grades.Add(new Grade(75));

            Console.WriteLine("\n=== Students Report ===");
            foreach (var s in new[] { s1, s2 })
            {
                Console.WriteLine($"Student {s.Name} (ID={s.Id}):");
                foreach (var c in s.Courses)
                    Console.WriteLine($"   Course: {c.Name} ({c.Level})");
                Console.WriteLine($"   Total Grade = {s.TotalGrade().Value}");
            }

            Console.WriteLine("\n=== Instructors Report ===");
            foreach (var inst in new[] { inst1, inst2 })
            {
                Console.WriteLine($"Instructor {inst.Name} (ID={inst.Id}):");
                foreach (var c in inst.CoursesTaught)
                    Console.WriteLine($"   Teaching: {c.Name}");
            }

            Console.WriteLine("\n=== Departments Report ===");
            foreach (var dept in company.departments)
            {
                Console.WriteLine($"Department {dept.Name}, Employees: {dept.employees.Count}");
            }

            Console.WriteLine("\n=== Car Demo ===");
            Car car = new Car { Make = "Toyota" };
            car.Engine.Model = "V8";
            car.Start();
        }
    }
}