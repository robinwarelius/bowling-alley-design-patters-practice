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

                    for (int i = 0; i <= persons.Count - 1; i++)
                    {
                        persons[i].UserTable.Score += finalScore[i];
                        db.SaveChanges();

                    }
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
