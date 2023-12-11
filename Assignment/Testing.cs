using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoublyLinkedListDemo;
using NUnit.Framework;

namespace Assignment
{
    [TestFixture]
    public class Testing
    {
        static Student s0 = new Student("Jeff Winger", "jeff.winger@hotmail.com", "720 555 0264", new Address(3060, "Osage Street", "Denver", 10912, "Colorado"), "Program", 19992022, new DateTime(), new Enrollment());
        static Student s1 = new Student("Britta Perry", "britta.perry@yahoo.com", "909 555 7538", new Address(2653, "Rakugaki Lane", "Denver", 10912, "Colorado"), "Program", 11132022, new DateTime(), new Enrollment());
        static Student s2 = new Student("Troy Bolton", "wildcatz@gmail.com", "505 555 3566", new Address(2002, "Chuo Street", "Albuquerque", 90210, "California"), "Program", 10172022, new DateTime(), new Enrollment());
        static Student s3 = new Student("Luz Noceda", "luzzz.colon3@aol.com", "475 555 2648", new Address(5686, "Boiling Isle", "Gravesfield", 11204, "Conneticut"), "Program", 15001692, new DateTime(), new Enrollment());
        static Student s4 = new Student("Program", 20015123, new DateTime());
        static Student s5 = new Student("John Smith", "example@email.com", "123 555 6789", new Address(), "Program", 12342005, new DateTime(), new Enrollment(new DateTime(), 11, 1));
        static Enrollment en = new Enrollment(new DateTime(), 12, 2, new Course[] { new Course("BRKFST985", "Communication Studies", 96.00), new Course("CHKFIN07", "Mixology Certification", 13.37) });
        static Student s6 = new Student("Jane Smith", "email2@example.com", "555 555 5555", new Address(), "Program", 16001850, new DateTime(), en);
        static Student s7 = s1;
        static Student s8 = s4;
        static Student s9 = new Student();

        static int[] studentsByID = new int[10] { s0.StudentStudentID, s1.StudentStudentID, s2.StudentStudentID, s3.StudentStudentID, s4.StudentStudentID, s5.StudentStudentID, s6.StudentStudentID, s7.StudentStudentID, s8.StudentStudentID, s9.StudentStudentID };
        static Student[] students = new Student[10] { s0, s1, s2, s3, s4, s5, s6, s7, s8, s9 };

        static DoublyLinkedList<Student> linkedList = new DoublyLinkedList<Student>();

        // Accomodated for changed Utility class (from generic to int)

        // 8.1.1
        [Test]
        public void testLinearSearch()
        {
            int index = Utility.SearchUnsorted(studentsByID, 15001692);
            Assert.That(index, Is.EqualTo(3));
        }

        // 8.1.2
        [Test]
        public void testBinarySearch()
        {
            // Array.Sort(studentsByID); doesn't work; throws error Invalid Operation Exception
            Utility.SortDescending(studentsByID);
            int[] list = new int[10] { studentsByID[0], studentsByID[1], studentsByID[2], studentsByID[3], studentsByID[4], studentsByID[5], studentsByID[6], studentsByID[7], studentsByID[8], studentsByID[9] };
            int index = Utility.SearchSorted(list, 15001692);
            Assert.That(index, Is.EqualTo(3));
        }

        // 8.1.3
        [Test]
        public void testBubbleSort()
        {
            int[] newList = Utility.SortAscending(studentsByID);
            Assert.That(newList[0], Is.EqualTo(-1));
        }

        // Nowhere in the assignment does it say to add a single linked list, so I didn't do 8.2.1a - 8.2.1e

        // 8.2.2a
        [Test]
        public void testAddHeadTolist()
        {
            linkedList.AddFirst(s3);
            Assert.That(linkedList.Head.Value, Is.EqualTo(s3));
        }

        // 8.2.2b
        [Test]
        public void testAddTailToList()
        {
            linkedList.AddLast(s3);
            Assert.That(linkedList.Tail.Value, Is.EqualTo(s3));
        }

        // 8.2.2c
        [Test]
        public void testFind()
        {
            linkedList.Add(s3);
            linkedList.Add(s2);
            linkedList.Add(s4);
            bool found = linkedList.Contains(s3);
            Assert.That(found, Is.True);
        }

        // 8.2.2
        [Test]
        public void testRemoveFirst()
        {
            linkedList.Add(s3);
            linkedList.Add(s2);
            linkedList.AddFirst(s4);
            linkedList.RemoveFirst();
            bool found = linkedList.Contains(s4);
            Assert.That(found, Is.False);
        }

        // 8.2.2e
        [Test]
        public void testRemoveLast()
        {
            linkedList.Add(s3);
            linkedList.Add(s2);
            linkedList.Add(s4);
            linkedList.RemoveLast();
            bool found = linkedList.Contains(s3);
            Assert.That(found, Is.False);
        }

        // 8.3
        [Test]
        public void testBinaryTree()
        {
            BinaryTree bTree = new BinaryTree();
            bTree.Add(0);
            bTree.Add(1);
            bTree.Add(2);
            bTree.Add(3);
            bTree.Add(4);
            bTree.Add(5);
            int i = bTree.Find(4).Data;

            Assert.That(i, Is.EqualTo(4));

        }

    }
}
