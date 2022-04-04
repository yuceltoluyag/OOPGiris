using System;


namespace ClassTuttorial
{
    // Inheritance

    class Program
    {
        public class Customer
        {
            public string Name;
            public string LastName;
            public string City;

            public void PrintFullName()
            {
                Console.WriteLine(Name + " " + LastName);
            }
        }
        public class LocalCustomer : Customer
        {
            public int MontlyPayment;

            public void PrintMontlyPayment()
            {
                Console.WriteLine("Montly Payment = " + MontlyPayment);
            }
        }

        public class ForeignCuster : Customer
        {
            public int YearlyPayment;
            public string Country;

            public void PrintYearlyPayment()
            {
                Console.WriteLine("Yearly Payment = " + YearlyPayment);
            }
        }
        static void Main()
        {
            LocalCustomer lcs = new LocalCustomer();
            lcs.Name = "Ahmet";
            lcs.LastName = "Varyemez";
            lcs.City = "Türkiye";
            lcs.MontlyPayment = 4500;
            lcs.PrintFullName();
            lcs.PrintMontlyPayment();
            Console.WriteLine("*********************************");
            ForeignCuster fcs = new ForeignCuster();
            fcs.Name = "Adam";
            fcs.LastName = "Coder";
            fcs.City = "New York";
            fcs.Country = "America";
            fcs.YearlyPayment = 45000;
            fcs.PrintFullName();
            fcs.PrintYearlyPayment();


            Console.ReadKey();
        }
    }

}

