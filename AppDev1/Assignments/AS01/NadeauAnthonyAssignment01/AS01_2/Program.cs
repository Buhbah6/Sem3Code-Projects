using System;

namespace AS01_2
{
    class HealthProfile
    {
        private String firstName;
        private String lastName;
        private int birthYear;
        private int currentYear;
        private double height;
        private double weight;
        
        public HealthProfile(String fname, String lname, int bYear, int cYear, double height, double weight)
        {
            FirstName = fname;
            LastName = lname;
            BirthYear = bYear;
            CurrentYear = cYear;
            Height = height;
            Weight = weight;
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

        public double Height
        {
            get { return height; }
            set 
            {   
                if (value > 0)
                    height = value;
                else
                    Console.WriteLine("Height must be positive.");
            }
        }

        public double Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                    weight = value;
                else
                    Console.WriteLine("Weight must be positive.");
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

        public double MinTargetHR
        {
            get { return Math.Round((0.5 * MaxHR), 0); }
        }

        public double MaxTargetHR
        {
            get { return Math.Round((0.85 * MaxHR), 0); }
        }

        public double CalcBMI(double weight, double height)
        {
           // return Math.Round((weight * 703) / Math.Pow(height, 2), 2);
            return (weight * 703) / Math.Pow(height, 2);
        }

        public String BMIVerbalRating(double weight, double height)
        {
            double bmi = CalcBMI(weight, height);
            if (bmi < 18.5)
                return "Underweight";
            else if (bmi >= 18.5 && bmi < 25)
                return "Normal";
            else if (bmi >= 25 && bmi < 30)
                return "Overweight";
            else
                return "Obese";
        }

        public void DisplayHealthRecord()
        {
            Console.WriteLine($"|-------------------------------------------------------|");
            Console.WriteLine($"|                 PATIENT HEALTH RECORD                 |");
            Console.WriteLine($"|-------------------------------------------------------|");
            Console.WriteLine($"| {"Patient Name",-25} | {lastName + ", " + firstName,-25} |");
            Console.WriteLine($"| {"Patient Birth Year",-25} | {birthYear,25} |");
            Console.WriteLine($"| {"Patient Age",-25} | {Age,25} |");
            Console.WriteLine($"| {"Patient Height",-25} | {Height,25} |");
            Console.WriteLine($"| {"Patient Weight",-25} | {Weight,25} |");
            Console.WriteLine($"| {"Maximum Heart Rate",-25} | {MaxHR,25} |");
            Console.WriteLine($"| {"Target Heart Rate Range",-25} | {MinTargetHR + " - " + MaxTargetHR,25} |");
            Console.WriteLine($"| {"BMI Numeric Value",-25} | {CalcBMI(Weight, Height),25:F} |");
            Console.WriteLine($"| {"BMI Verbal Rating",-25} | {BMIVerbalRating(Weight, Height),-25} |");
            Console.WriteLine($"|-------------------------------------------------------|");
            Console.WriteLine();
        }
    }

    class Driver
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Please enter your first name: ");
            String fname = Console.ReadLine();
            Console.WriteLine("Please enter your last name: ");
            String lname = Console.ReadLine();
            Console.WriteLine("Please enter your birth year: ");
            int bYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the current year: ");
            int cYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your height in inches: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter your weight in pounds: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            HealthProfile hp = new HealthProfile(fname, lname, bYear, cYear, height, weight);
            hp.DisplayHealthRecord();

        }
    }

}
