
namespace CshardCourceITI
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Course> courses { get; set; }
        public Employee(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    public class Department
    {
        public string Name { get; set; }
        public List<Employee> employees { get; set; } = new List<Employee>();
    }
    public class Company
    {
        public string Name { get; set; }
        public List<Department> departments {  get; set; } = new List<Department>();

    }

    public class Engine
    {
        public string Model { get; set; }
        public void Start() => Console.WriteLine($"Engine {Model} started!");
    }
    public class Car
    {
        public string Make { get; set; }
        public Engine Engine { get; } = new Engine();
        public void Start() => Engine.Start();
    }

    ////////////////////////////////////////////////////////////////////

    public abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        protected Person(string name, int age)
        {
            Name = name; Age = age;
        }
        public abstract void Introduce();
    }

    public class Instructor : Person
    {
        public List<Course> CoursesTaught { get; } = new List<Course>();
        public int Id { get; set; }
        public Instructor(string name, int age) : base(name, age) { }
        public void TeachCourse(Course course)
        {
            course.instructor = this;
            CoursesTaught.Add(course);
        }
        public override void Introduce()
            => Console.WriteLine($"I am Instructor {Name}, I teach {CoursesTaught.Count} courses.");
    }

    // Student
    public class Student : Person
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public List<Course> Courses { get; } = new List<Course>();
        public List<Grade> Grades { get; } = new List<Grade>();
        public Student(string name, int age, int id) : base(name, age)
        {
            Id = id;
        }
        public void RegisterCourse(Course course)
        {
            Courses.Add(course);
            course.students.Add(this);

            switch (course.Level)
            {
                case CourseLevel.Beginner:
                    Console.WriteLine($"{Name} registered in {course.Name}. Good luck starting out!");
                    break;
                case CourseLevel.Intermediate:
                    Console.WriteLine($"{Name} registered in {course.Name}. Keep learning!");
                    break;
                case CourseLevel.Advanced:
                    Console.WriteLine($"{Name} registered in {course.Name}. This will be challenging!");
                    break;
            }
        }
        public Grade TotalGrade()
        {
            Grade total = new Grade(0);
            foreach (var g in Grades)
                total += g;
            return total;
        }
        public override void Introduce()
            => Console.WriteLine($"I am Student {Name}, I am learning {Courses.Count} courses.");
    }

    ////////////////////////////////////////////////////////////////////

    public static class IdGen
    {
        private static int counter = 0;
        public static int GenId() => ++counter;
    }

    public abstract class Person_Id
    {
        public int Id { get; }
        public string Name { get; set; }
        public int Age { get; set; }
        protected Person_Id(string name, int age)
        {
            Id = IdGen.GenId();
            Name = name; Age = age;
        }
        public abstract void Introduce();
    }

    ////////////////////////////////////////////////////////////////////

    public enum CourseLevel { Beginner, Intermediate, Advanced }
    public class Course
    {
        public string Name { get; set; }
        public CourseLevel Level { get; set; }
        public Instructor instructor { get; set; }
        public List<Student> students { get; } = new List<Student>();
        public Course(string name, CourseLevel level)
        {
            Name = name;
            Level = level;
        }
    }

    public class Grade
    {
        public int Value { get; set; }
        public Grade(int value) => Value = value;
        public static Grade operator +(Grade g1, Grade g2)
            => new Grade(g1.Value + g2.Value);
        public static bool operator ==(Grade g1, Grade g2)
        {
            return g1.Value == g2.Value;
        }
        public static bool operator !=(Grade g1, Grade g2)
            => !(g1 == g2);
    }
    
}