using BengansBowlingApplikation.UIclasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BengansBowlingApplikation.Classes.UI
{
    public static class WinnerDataCapture
    {
        public static List <string> Capture()
        {          
            List<string> list = new List<string>();
            Console.WriteLine("UPDATE SCORE");
            Console.WriteLine("Enter email of winner: ");
            list.Add(Console.ReadLine());
            Console.WriteLine("Enter score: "); 
            list.Add (Console.ReadLine());
            return list;           
        }
    }
}
