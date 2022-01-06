using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS02
{
    using System;

    // Class customer inherits the instance variables of the Person class
    public class Customer : Person
    {
        // Instance variables
        private int cusNum;
        private bool mailList;

        // Constructor that uses properties to initialize the instance variables as well as the base constructor
        public Customer(String lName, String fName, String add, String pNumber, int cusNum, bool mailList)
            : base(lName, fName, add, pNumber)
        {

            CusNum = cusNum;
            MailList = mailList;
        }

        // CusNum property (with basic exception handling)
        public int CusNum
        {
            get { return cusNum; }
            set
            {
                if (cusNum < 0)
                {
                    cusNum = 99999;
                    Console.WriteLine("Customer number should be a positive integer value;");
                }
                else
                    cusNum = value;
            }
        }

        // MailList property
        public bool MailList
        {
            get { return mailList; }
            set { mailList = value; }
        }

        // Overridden DisplayData method
        public override void DisplayData()
        {
            // if else statement to make it print out Yes or No and not True or false
            String yesOrNo;
            if (MailList)
                yesOrNo = "Yes";
            else
                yesOrNo = "No";
            Console.WriteLine($"|---------------------------------------------------------|");
            Console.WriteLine($"|                          CUSTOMER                       |");
            Console.WriteLine($"|---------------------------------------------------------|");
            Console.WriteLine($"| {"Customer Number",-22} | {CusNum,30} |");
            Console.WriteLine($"| {"Last Name",-22} | {LastName,-30} |");
            Console.WriteLine($"| {"First Name",-22} | {FirstName,-30} |");
            Console.WriteLine($"| {"Address",-22} | {Address,-30} |");
            Console.WriteLine($"| {"Phone Number",-22} | {PhoneNumber,30} |");
            Console.WriteLine($"| {"Mailing List",-22} | {yesOrNo,-30} |");
            Console.WriteLine($"|---------------------------------------------------------|");
            Console.WriteLine();
        }
    }
}
