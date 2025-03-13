using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _133labtask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter firstName ");
            string firstName = Console.ReadLine();
            
            Console.WriteLine("Enter LastName ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter Birthday");
            string birthdate = Console.ReadLine();

            Console.WriteLine("Enter addressLine1 ");
            string addressLine1 = Console.ReadLine();

            Console.WriteLine("Enter addressLine2 ");
            string addressLine2 = Console.ReadLine();

            Console.WriteLine("Enter City");
            string city = Console.ReadLine();

            Console.WriteLine("Enter State ");
            string stateProvince = Console.ReadLine();

            Console.WriteLine("Enter ZipPostal");
            string zipPostal = Console.ReadLine();

            Console.WriteLine("Enter Contry");
            string country = Console.ReadLine();



            Console.WriteLine("Student Information:");
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);
            Console.WriteLine("Birthdate: " + birthdate);
            Console.WriteLine("Address Line 1: " + addressLine1);
            Console.WriteLine("Address Line 2: " + addressLine2);
            Console.WriteLine("City: " + city);
            Console.WriteLine("State/Province: " + stateProvince);
            Console.WriteLine("Zip/Postal: " + zipPostal);
            Console.WriteLine("Country: " + country);




        }
    }
}
