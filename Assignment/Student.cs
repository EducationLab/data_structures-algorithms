using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Student : Person
    {
        private static string DEF_PROGRAM = "No Program";
        private static DateTime DEF_DATE_REGISTERED = new DateTime(1940, 1, 1);
        private static int DEF_STUDENT_ID = -1;

        private string Program;
        private int StudentID;
        private DateTime DateRegistered;
        private Enrollment Enrollment;

        public string StudentProgram
        {
            get { return Program; }
            set { Program = value; }
        }
        public int StudentStudentID
        {
            get { return StudentID; }
            set { StudentID = value; }
        }
        public DateTime StudentDateRegistered
        {
            get { return DateRegistered; }
            set { DateRegistered = value; }
        }
        public Enrollment StudentEnrollment
        {
            get { return Enrollment; }
            set { Enrollment = value; }
        }

        public Student() : this(DEF_PROGRAM, DEF_STUDENT_ID, DEF_DATE_REGISTERED)
        {

        }

        public Student(string program, int studentID, DateTime dateRegistered) : this(program, studentID, dateRegistered, new Enrollment())
        {

        }

        public Student(string program, int studentID, DateTime dateRegistered, Enrollment enrollment) : this(DEF_NAME, DEF_EMAIL, DEF_TELNUM, new Address(), program, studentID, dateRegistered, enrollment)
        {
            
        }

        public Student(string name, string email, string telNum, Address address, string program, int studentID, DateTime dateRegistered, Enrollment enrollment) : base(name, email, telNum, address)
        {
            this.Program = program;
            this.StudentID = studentID;
            this.DateRegistered = dateRegistered;
            this.Enrollment = enrollment;
        }

        public override string ToString()
        {
            return this.Program + ", Date Registered: " + this.DateRegistered + "\n" + this.Enrollment;
        }

        public static bool operator ==(Student a, Student b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(Student a, Student b)
        {
            return !(a.Equals(b));
        }

        public override bool Equals(object obj)
        {
            return this == (Student) obj;
        }

        /*public static bool operator <=(Student a, Student b)
        {
            bool status = false; ;

            if (a.Enrollment.EnrollmentCourses.Length <= b.Enrollment.EnrollmentCourses.Length)
                status = true;

            return status;
        }

        public static bool operator >=(Student a, Student b)
        {
            bool status = false; ;

            if (a.Enrollment.EnrollmentCourses.Length >= b.Enrollment.EnrollmentCourses.Length)
                status = true;

            return status;
        }

        public static bool operator <(Student a, Student b)
        {
            bool status = false; ;

            if (a.Enrollment.EnrollmentCourses.Length < b.Enrollment.EnrollmentCourses.Length)
                status = true;

            return status;
        }

        public static bool operator >(Student a, Student b)
        {
            bool status = false; ;

            if (a.Enrollment.EnrollmentCourses.Length > b.Enrollment.EnrollmentCourses.Length)
                status = true;

            return status;
        }*/

        public static bool operator <=(Student a, Student b)
        {
            bool status = false; ;

            if (a.StudentID <= b.StudentID)
                status = true;

            return status;
        }

        public static bool operator >=(Student a, Student b)
        {
            bool status = false; ;

            if (a.StudentID >= b.StudentID)
                status = true;

            return status;
        }

        public static bool operator <(Student a, Student b)
        {
            bool status = false; ;

            if (a.StudentID < b.StudentID)
                status = true;

            return status;
        }

        public static bool operator >(Student a, Student b)
        {
            bool status = false; ;

            if (a.StudentID > b.StudentID)
                status = true;

            return status;
        }

        public override int GetHashCode()
        {
            int hashedID = StudentID.GetHashCode();
            // DateRegistered.GetHashCode();

            return hashedID;
        }
    }
}
