using DoublyLinkedListDemo;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s0 = new Student("Jeff Winger", "jeff.winger@hotmail.com", "720 555 0264", new Address(3060, "Osage Street", "Denver", 10912, "Colorado"), "Program", 19992022, new DateTime(), new Enrollment());
            Student s1 = new Student("Britta Perry", "britta.perry@yahoo.com", "909 555 7538", new Address(2653, "Rakugaki Lane", "Denver", 10912, "Colorado"), "Program", 11132022, new DateTime(), new Enrollment());
            Student s2 = new Student("Troy Bolton", "wildcatz@gmail.com", "505 555 3566", new Address(2002, "Chuo Street", "Albuquerque", 90210, "California"), "Program", 10172022, new DateTime(), new Enrollment());
            Student s3 = new Student("Luz Noceda", "luzzz.colon3@aol.com", "475 555 2648", new Address(5686, "Boiling Isle", "Gravesfield", 11204, "Conneticut"), "Program", 15001692, new DateTime(), new Enrollment());
            Student s4 = new Student("Program", 20015123, new DateTime());
            Student s5 = new Student("John Smith", "example@email.com", "123 555 6789", new Address(), "Program", 12342005, new DateTime(), new Enrollment(new DateTime(), 11, 1));
            Enrollment en = new Enrollment(new DateTime(), 12, 2, new Course[] { new Course("BRKFST985", "Communication Studies", 96.00), new Course("CHKFIN07", "Mixology Certification", 13.37) });
            Student s6 = new Student("Jane Smith", "email2@example.com", "555 555 5555", new Address(), "Program", 16001850, new DateTime(), en);
            Student s7 = s1;
            Student s8 = s4;
            Student s9 = new Student();

            int[] studentsByID = new int[10] { s0.StudentStudentID, s1.StudentStudentID, s2.StudentStudentID, s3.StudentStudentID, s4.StudentStudentID, s5.StudentStudentID, s6.StudentStudentID, s7.StudentStudentID, s8.StudentStudentID, s9.StudentStudentID };
            // int[] studentsByID = new int[10] { s0.StudentStudentID, s1.StudentStudentID, s2.StudentStudentID, s3.StudentStudentID, s4.StudentStudentID, s5.StudentStudentID, s6.StudentStudentID, s7.StudentStudentID, s8.StudentStudentID, s9.StudentStudentID };
            // Student[] students = new Student[10] { s0, s1, s2, s3, s4, s5, s6, s7, s8, s9 };
            //int index = Utility.SearchUnsorted(studentsByID, 15001692);
            //Console.WriteLine(index);
            //int index = Utility.SearchUnsorted(studentsByID, 15001692);
            DoublyLinkedList<Student> linkedList = new DoublyLinkedList<Student>();
            linkedList.Add(s3);
            linkedList.Add(s2);
            linkedList.Add(s4);
            linkedList.RemoveLast();
            bool found = linkedList.Contains(s3);
            Console.WriteLine(found);
            Console.ReadKey();



        }
    }
}
