using BengansBowlingApplikation.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BengansBowlingApplikation.UIclasses
{
    public static class StandardMessages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome - Bengans Bowlinghall");
        }

        public static void DisplayValidationErrorMenu()
        {
            Console.WriteLine("You dident give us a valid input. Press enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }

        public static void DisplayValidationErrorRegistration(string fieldName)
        {
            Console.WriteLine($"You dident give us a valid {fieldName}. Registration faild. Press enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }

        public static void DisplayValidationSuccesRegistration(string fieldName)
        {
            Console.WriteLine($"Registration succed: {fieldName}. Press enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }

        public static void DisplayValidationErrorBooking ()
        {
            Console.WriteLine("Sry no more spots are availible for the contest or email. Press enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }

        public static void DisplayScore (List <IPerson> persons)
        {
            foreach (var user in persons)
            {
                Console.WriteLine($"{user.FirstName} {user.LastName} | Matches Won: {user.Score}");
            }

            Console.ReadLine();
            Console.Clear();          
           
        }
    }
}
