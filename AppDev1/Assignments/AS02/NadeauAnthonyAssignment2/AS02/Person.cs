using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS02
{
    public class Person
    {
        // Instance Variables
        private String lastName;
        private String firstName;
        private String address;
        private String phoneNumber;

        // Constructor using all properties to initialize instance variables
        public Person(String ln, String fn, String add, String pn)
        {
            LastName = ln;
            FirstName = fn;
            Address = add;
            PhoneNumber = pn;
        }

        // LastName property
        public String LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        // FirstName property
        public String FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        // Address property
        public String Address
        {
            get { return address; }
            set { address = value; }
        }

        // PhoneNumber property
        public String PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        // DisplayData method to format and display the data within the object
        public virtual void DisplayData()
        {
            Console.WriteLine($"|-------------------------------------------------------|");
            Console.WriteLine($"|                          PERSON                       |");
            Console.WriteLine($"|-------------------------------------------------------|");
            Console.WriteLine($"| {"Last Name",-20} | {LastName,-30} |");
            Console.WriteLine($"| {"First Name",-20} | {FirstName,-30} |");
            Console.WriteLine($"| {"Address",-20} | {Address,-30} |");
            Console.WriteLine($"| {"Phone Number",-20} | {PhoneNumber,30} |");
            Console.WriteLine($"|-------------------------------------------------------|");
            Console.WriteLine();
        }
    }
}