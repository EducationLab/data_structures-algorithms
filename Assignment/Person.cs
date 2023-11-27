using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Person
    {
        protected static string DEF_NAME = "No Name";
        protected static string DEF_EMAIL = "email@example.com";
        protected static string DEF_TELNUM = "No Number";

        protected string Name;
        protected string Email;
        protected string TelNum;
        protected Address Address;

        public string PersonName
        {
            get { return Name; }
            set { Name = value; }
        }
        public string PersonEmail
        {
            get { return Email; }
            set { Email = value; }
        }
        public string PersonTelNum
        {
            get { return TelNum; }
            set { TelNum = value; }
        }
        public Address PersonAddress
        {
            get { return Address; }
            set { Address = value; }
        }

        public Person() : this(DEF_NAME, DEF_EMAIL, DEF_TELNUM)
        {

        }

        public Person(string name, string email, string telNum) : this(name, email, telNum, new Address())
        {

        }

        public Person(string name, string email, string telNum, Address address)
        {
            this.Name = name;
            this.Email = email;
            this.TelNum = telNum;
            this.Address = address;
        }

        public override string ToString()
        {
            return this.Name + ", Email: " + this.Email + ", Tel (" + this.TelNum + ")\n" + this.Address;
        }
    }
}
