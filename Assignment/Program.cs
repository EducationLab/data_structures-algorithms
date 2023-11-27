using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Address());
            Console.WriteLine();
            Console.WriteLine(new Person());
            Console.WriteLine();

            Student s = new Student();
            Console.WriteLine(s);

            Console.ReadKey();

            s.Enrollment.AddCourse(new Course("12M", "Class", 230.7));
            Console.WriteLine(s);
            Console.WriteLine(s.Enrollment.Courses);
            Console.ReadKey();

            Course[] c = new Course[] { new Course(), new Course() };
            Enrollment e = new Enrollment();
            e.Courses = c;
            Console.WriteLine(e);
            c.Append(new Course());
            e.Courses = c;
            Console.WriteLine(e);
            Console.ReadKey();
        }
    }
}
