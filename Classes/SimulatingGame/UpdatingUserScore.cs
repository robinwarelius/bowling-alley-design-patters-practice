using BengansBowlingApplikation.Models;
using BengansBowlingApplikation.UIclasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BengansBowlingApplikation.Classes.SimulatingGame
{
    public static class UpdatingUserScore
    {
        public static bool UpdateScore(List<int> finalScore, List<string> email)
        {
            try
            {
                using (BengansBowlingEntities1 db = new BengansBowlingEntities1())
                {
                    var persons = db.BookTable.Where(u => u.UserNumber == u.UserNumber).ToList();

                    var maxIndex = finalScore.IndexOf(finalScore.Max());

                    Console.WriteLine($"WÌNNER: {persons[maxIndex].UserTable.FirstName} {persons[maxIndex].UserTable.LastName}");
                    persons[maxIndex].UserTable.Score += 1;
                    db.SaveChanges();

                    StandardMessages.DisplayValidationSuccesRegistration("score");
                    return true;
                }
           
            } catch (Exception ex)
            {
                return false;
            }
        }
    }
}
