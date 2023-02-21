using BengansBowlingApplikation.Classes.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BengansBowlingApplikation.UIclasses
{
    public static class ContestDataCapture
    {
        public static List <string> capture()
        {
            try
            {
                var capture = new List<string>();
                Console.WriteLine("Register Contest");
                Console.Write("Date (yyyy-mm-dd): ");
                capture.Add(Console.ReadLine());
                Console.Write("Time (hh:mm): ");
                capture.Add(Console.ReadLine());
                return capture;
            }
            catch (Exception ex)
            {
                Factory.Factory.CreateLogger(ex.Message);
                return null;
            }
            
        }
    }
}
