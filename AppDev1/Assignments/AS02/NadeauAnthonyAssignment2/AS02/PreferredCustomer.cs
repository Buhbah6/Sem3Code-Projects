using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS02
{
    // PreferredCustomer class that inherits from Customer
    public class PreferredCustomer : Customer
    {
        // Instance Variables
        private decimal purchaseAmount;
        private int discountLevel;

        // Constructor with all new and inherited instance variables - calls base constructor
        public PreferredCustomer(String lName, String fName, String add, String pNumber, int cusNum, bool mailList, decimal purchAmnt)
            : base(lName, fName, add, pNumber, cusNum, mailList)
        {
            PurchaseAmount = purchAmnt;
            DiscountLevel = 25; // 25 is random value
        }

        // PurchaseAmount property  (With basic exception handling)
        public decimal PurchaseAmount
        {
            get { return purchaseAmount; }
            set
            {
                if (purchaseAmount < 0)
                {
                    purchaseAmount = 0;
                    Console.WriteLine("Customer purchases amount should be a positive value");
                }
                else
                    purchaseAmount = value;
            }
        }

        // DiscountLevel property that sets the value based on pre-determined specifications
        public int DiscountLevel
        {
            get { return discountLevel; }
            set
            {
                if (purchaseAmount >= 500 && purchaseAmount < 1000)
                    discountLevel = 5;
                else if (purchaseAmount >= 1000 && purchaseAmount < 1500)
                    discountLevel = 6;
                else if (purchaseAmount >= 1500 && purchaseAmount < 2000)
                    discountLevel = 7;
                else if (purchaseAmount >= 2000)
                    discountLevel = 10;
            }
        }

        // Overridden DisplayData method
        public override void DisplayData()
        {
            String yesOrNo;
            if (MailList)
                yesOrNo = "Yes";
            else
                yesOrNo = "No";

            Console.WriteLine($"|---------------------------------------------------------|");
            Console.WriteLine($"|                   PREFERRED CUSTOMER                    |");
            Console.WriteLine($"|---------------------------------------------------------|");
            Console.WriteLine($"| {"Customer Number",-22} | {CusNum,30} |");
            Console.WriteLine($"| {"Last Name",-22} | {LastName,-30} |");
            Console.WriteLine($"| {"First Name",-22} | {FirstName,-30} |");
            Console.WriteLine($"| {"Address",-22} | {Address,-30} |");
            Console.WriteLine($"| {"Phone Number",-22} | {PhoneNumber,30} |");
            Console.WriteLine($"| {"Mailing List",-22} | {yesOrNo,-30} |");
            Console.WriteLine($"| {"Purchase Amount",-22} | {"$" + PurchaseAmount,30} |");
            //Console.WriteLine($"| {"Discount Level",-22} | {DiscountLevel + "%",30} |");
            Console.WriteLine($"| {"Discount Level",-22} | {(float) DiscountLevel / 100 , 30:P} |");
            Console.WriteLine($"|---------------------------------------------------------|");
            Console.WriteLine();
        }
    }
}
