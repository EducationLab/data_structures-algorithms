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

        private string Program;
        private DateTime DateRegistered;
        private Enrollment Enrollment;

        public string StudentProgram
        {
            get { return Program; }
            set { Program = value; }
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

        public Student() : this(DEF_PROGRAM, DEF_DATE_REGISTERED)
        {

        }

        public Student(string program, DateTime dateRegistered) : this(program, dateRegistered, new Enrollment())
        {

        }

        public Student(string program, DateTime dateRegistered, Enrollment enrollment) : this(DEF_NAME, DEF_EMAIL, DEF_TELNUM, new Address(), program, dateRegistered, enrollment)
        {
            
        }

        public Student(string name, string email, string telNum, Address address, string program, DateTime dateRegistered, Enrollment enrollment) : base(name, email, telNum, address)
        {
            this.Program = program;
            this.DateRegistered = dateRegistered;
            this.Enrollment = enrollment;
        }

        public override string ToString()
        {
            return this.Program + ", Date Registered: " + this.DateRegistered + "\n" + this.Enrollment;
        }
    }
}
