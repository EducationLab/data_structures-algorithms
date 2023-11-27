using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Address
    {
        private static int DEF_NUMBER = -1;
        private static string DEF_STREET = "No Street";
        private static string DEF_SUBURB = "No Suburb";
        private static int DEF_POSTCODE = -1000;
        private static string DEF_STATE = "No State";

        private int Number;
        private string Street;
        private string Suburb;
        private int Postcode;
        private string State;

        public int AddressNumber
        {
            get { return Number; }
            set { Number = value; }
        }
        public string AddressStreet
        {
            get { return Street; }
            set { Street = value; }
        }
        public string AddressSuburb
        {
            get { return Suburb; }
            set { Suburb = value; }
        }
        public int AddressPostcode
        {
            get { return Postcode; }
            set { Postcode = value; }
        }
        public string AddressState
        {
            get { return State; }
            set { State = value; }
        }

        public Address() : this(DEF_NUMBER, DEF_STREET, DEF_SUBURB, DEF_POSTCODE, DEF_STATE)
        {
            
        }

        public Address(int number, string street, string suburb, int postcode, string state)
        {
            this.Number = number;
            this.Street = street;
            this.Suburb = suburb;
            this.Postcode = postcode;
            this.State = state;
        }

        public override string ToString()
        {
            return this.Number + " " + this.Street + ", " + this.Suburb + ", " + this.State + ", " + this.Postcode;
        }
    }
}
