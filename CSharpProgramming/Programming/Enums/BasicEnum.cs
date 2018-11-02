using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Enums
{
    public class BasicEnum
    {
        public static void Main()
        {
            Customer[] customers = new Customer[3];
            customers[0] = new Customer()
            {
                Name = "Mark",
                Gender = Gender.Male
            };
            customers[1] = new Customer()
            {
                Name = "Mary",
                Gender = Gender.Female
            };
            customers[2] = new Customer()
            {
                Name = "Sam",
                Gender = Gender.Unknown
            };
            foreach (Customer customer in customers)
            {
                Console.WriteLine("Name = {0} && Gender = {1}", customer.Name, GetGender(customer.Gender));
            }
        }


        public static string GetGender(Gender gender)
        {
            // The swicth here is now more readable and maintainable because 
            // of replacing the integral numbers with Gender enum
            switch (gender)
            {
                case Gender.Unknown:
                    return "Unknown";
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                default:
                    return "Invalid Data for Gender";
            }
        }
    }


    public enum Gender
    {
        Unknown = 0,
        Male = 1,
        Female = 2
    }


    public class Customer
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
    }
}
