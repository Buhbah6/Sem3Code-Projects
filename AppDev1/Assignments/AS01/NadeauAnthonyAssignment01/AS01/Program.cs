using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS01_2
{
    class HeartRates
    {
        private String firstName;
        private String lastName;
        private int birthYear;
        private int currentYear;

        public HeartRates(String fName, String lName, int bYear, int cYear)
        {
            FirstName = fName;
            LastName = lName;
            BirthYear = bYear;
            CurrentYear = cYear;
        }

        public String FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public String LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public int BirthYear
        {
            get { return birthYear; }
            set 
            {
                if (value > 0)
                    birthYear = value;
                else
                    Console.WriteLine("Birth Year must be positive.");
            }
        }

        public int CurrentYear
        {
            get { return currentYear; }
            set
            {
                if (value > 0)
                    currentYear = value;
                else
                    Console.WriteLine("Current Year must be positive.");
            }
        }

        public int Age
        {
            get { return currentYear - birthYear; }
        }

        public int MaxHR
        {
            get { return 220 - Age; }
        }

        public double MaxTargetHR
        {
            get { return Math.Round((0.85 * MaxHR), 0); }
        }

        public double MinTargetHR
        {
            get { return Math.Round((0.50 * MaxHR), 0); }
        }

        public void DisplayPatientRecord()
        {
            Console.WriteLine($"|-------------------------------------------------------|");
            Console.WriteLine($"|               PATIENT HEART RATE RECORD               |");
            Console.WriteLine($"|-------------------------------------------------------|");
            Console.WriteLine($"| {"Patient Name",-25} | {lastName + ", " + firstName, -25} |");
            Console.WriteLine($"| {"Patient Birth Year",-25} | {birthYear, 25} |");
            Console.WriteLine($"| {"Patient Age",-25} | {Age, 25} |");
            Console.WriteLine($"| {"Maximum Heart Rate",-25} | {MaxHR, 25} |");
            Console.WriteLine($"| {"Target Heart Rate Range",-25} | {MinTargetHR + " - " + MaxTargetHR, 25} |");
            Console.WriteLine($"|-------------------------------------------------------|");
            Console.WriteLine();
        }

    }

    public class Driver
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Please enter your first name: ");
            String fName = Console.ReadLine();
            Console.WriteLine("Please enter your last name: ");
            String lName = Console.ReadLine();
            Console.WriteLine("Please enter your birth year: ");
            int bYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the current year: ");
            int cYear = Convert.ToInt32(Console.ReadLine());
            HeartRates h1 = new HeartRates(fName, lName, bYear, cYear);
            h1.DisplayPatientRecord();
        }
    }
}
