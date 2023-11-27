using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Course
    {
        private static string DEF_COURSE_CODE = "No Code";
        private static string DEF_COURSE_NAME = "No Name";
        private static double DEF_COST = 0.0;

        private string CourseCode;
        private string CourseName;
        private double Cost;

        public string CourseCourseCode
        {
            get { return CourseCode; }
            set { CourseCode = value; }
        }
        public string CourseCourseName
        {
            get { return CourseName; }
            set { CourseName = value; }
        }
        public double CourseCost
        {
            get { return Cost; }
            set { Cost = value; }
        }

        public Course() : this(DEF_COURSE_CODE, DEF_COURSE_NAME, DEF_COST)
        {

        }

        public Course(string courseCode, string courseName, double cost)
        {
            this.CourseCode = courseCode;
            this.CourseName = courseName;
            this.Cost = cost;
        }

        public override string ToString()
        {
            return this.CourseName + " (" + this.CourseCode + "): $" + this.Cost;
        }
    }
}
