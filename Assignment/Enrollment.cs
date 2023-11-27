using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Enrollment
    {
        private static DateTime DEF_DATE_ENROLLED = new DateTime(1940, 1, 1);
        private static int DEF_GRADE = -1;
        private static int DEF_SEMESTER = -1;

        private DateTime DateEnrolled;
        private int Grade;
        private int Semester;
        private Course[] Courses;

        public DateTime EnrollmentDateEnrolled
        {
            get { return DateEnrolled; }
            set { DateEnrolled = value; }
        }
        public int EnrollmentGrade
        {
            get { return Grade; }
            set { Grade = value; }
        }
        public int EnrollmentSemester
        {
            get { return Semester; }
            set { Semester = value; }
        }
        public Course[] EnrollmentCourses
        {
            get { return Courses; }
            set { Courses = value; }
        }

        public Enrollment() : this(DEF_DATE_ENROLLED, DEF_GRADE, DEF_SEMESTER)
        {

        }

        public Enrollment(DateTime dateEnrolled, int grade, int semester) : this(dateEnrolled, grade, semester, new Course())
        {

        } 

        public Enrollment(DateTime dateEnrolled, int grade, int semester, Course course)
        {
            this.DateEnrolled = EnrollmentDateEnrolled;
            this.Grade = grade;
            this.Semester = semester;
            this.Courses = new Course[] { course };
        }

        public Enrollment(DateTime dateEnrolled, int grade, int semester, Course[] courses)
        {
            this.DateEnrolled = EnrollmentDateEnrolled;
            this.Grade = grade;
            this.Semester = semester;
            this.Courses = courses;
        }

        public void AddCourse(Course course)
        {
            this.Courses.Append(course);
        }

        public override string ToString()
        {
            string s = "Enrollment Date: " + this.DateEnrolled + ", Grade: " + this.Grade + ",Semester: " + this.Semester + "\nCourses:\n";
            foreach (Course course in this.Courses)
            {
                s += course.ToString();
                s += "\n";
            }
            return s;
        }
    }
}
