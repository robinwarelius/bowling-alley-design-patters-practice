using BengansBowlingApplikation.Classes.Logger;
using BengansBowlingApplikation.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BengansBowlingApplikation.UIclasses
{
    public class CompetitionParticipantCapture
    {

        public static string Capture(IContest contest)
        {
            try
            {
                string email;
                Console.WriteLine("Next Competition");
                Console.WriteLine($"date: {contest.Date} | time: {contest.Time}");
                Console.Write("Email of participate: ");
                email = Console.ReadLine();
                return email;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex.Message);
                return null;
            }
                                          
        } 
    }
}
