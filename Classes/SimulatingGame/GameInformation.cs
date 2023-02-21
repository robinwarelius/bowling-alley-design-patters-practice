using BengansBowlingApplikation.Models;
using BengansBowlingApplikation.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BengansBowlingApplikation.Classes.SimulatingGame
{
    public static class GameInformation
    {
        
        public static void part01()
        {
            using (BengansBowlingEntities1 db = new BengansBowlingEntities1())
            {
                var date = db.ContestTable.Where(d => d.ContestDate == d.ContestDate).OrderBy(c => c.ContestDate).FirstOrDefault();
                var contestParticipants = db.BookTable.Where(u => u.UserNumber == u.UserNumber).ToList();

                Console.WriteLine($"{date.ContestDate}");
                Console.WriteLine("Dagens deltagare:");
                List<string> name = new List<string>();
                List<string> email = new List<string>();
                foreach (var i in contestParticipants)
                {
                    Console.WriteLine($"{i.UserTable.FirstName} {i.UserTable.LastName}");
                    name.Add($"{i.UserTable.FirstName} {i.UserTable.LastName}");
                    email.Add(i.UserTable.Email);
                }

                CaptureScore.part02(name, email);
            }
            
        }
                 
    }
}

