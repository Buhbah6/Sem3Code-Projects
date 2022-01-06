using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS02
{
    public class Driver
    {
        public static void Main(String[] args)
        {
            // Retrieving user input
            Console.WriteLine("Please enter your Customer Number: ");
            int cusNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your last name: ");
            String lName = Console.ReadLine();
            Console.WriteLine("Please enter your first name: ");
            String fName = Console.ReadLine();
            Console.WriteLine("Please enter your address: ");
            String address = Console.ReadLine();
            Console.WriteLine("Please enter your phone number: ");
            String pNum = Console.ReadLine();

            // While loop to ensure that an invalid value cannot be taken for the mailList
            String answer;
            bool mailList = false;
            bool validAnswer = false;

            while (!validAnswer)
            {
                Console.WriteLine("Would you like to be on a mailing list? ('Y' or 'N'): ");
                answer = Console.ReadLine();
                if (answer.ToUpper() == "Y" || answer.ToUpper() == "YES")
                {
                    mailList = true;
                    validAnswer = true;
                }
                else if (answer.ToUpper() == "N" || answer.ToUpper() == "NO")
                {
                    mailList = false;
                    validAnswer = true;
                }
            }

            Console.WriteLine("Please enter the total amount of all your purchases (in $)");
            decimal purchAmnt = Convert.ToDecimal(Console.ReadLine());

            // Creating objects using the user input
            Person p = new Person(lName, fName, address, pNum);
            Customer c = new Customer(lName, fName, address, pNum, cusNum, mailList);
            PreferredCustomer pc = new PreferredCustomer(lName, fName, address, pNum, cusNum, mailList, purchAmnt);

            // Calling DisplayData method for each object
            p.DisplayData();
            c.DisplayData();
            pc.DisplayData();
        }
    }
}
