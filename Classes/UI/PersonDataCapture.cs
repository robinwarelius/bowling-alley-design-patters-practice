using BengansBowlingApplikation.Classes.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BengansBowlingApplikation.UIclasses
{
    public static class PersonDataCapture
    {
        public static List<string> Capture()
        {
            try
            {
                List<string> person = new List<string>();

                Console.WriteLine("Enter firstname: ");
                person.Add(Console.ReadLine());
                Console.WriteLine("Enter lastname: ");
                person.Add(Console.ReadLine());
                Console.WriteLine("Enter email: ");
                person.Add(Console.ReadLine());
                Console.WriteLine("Enter adress: ");
                person.Add(Console.ReadLine());
                Console.WriteLine("Enter personal identity number: ");
                person.Add(Console.ReadLine());

                return person;
            }
            catch(Exception ex)
            {
                Factory.Factory.CreateLogger(ex.Message);
                return null;
            }
            

        }

    }
}
