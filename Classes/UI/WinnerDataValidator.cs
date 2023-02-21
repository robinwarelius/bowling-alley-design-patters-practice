using BengansBowlingApplikation.Services.Interfaces;
using BengansBowlingApplikation.UIclasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace BengansBowlingApplikation.Classes.UI
{
    public static class WinnerDataValidator
    {
        public static bool Validate(List<string> winnerPerson)
        {
            try
            {
                int score;
                if (int.TryParse(winnerPerson[1], out score))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            } catch (Exception ex)
            {
                Factory.Factory.CreateLogger(ex.Message);
                StandardMessages.DisplayValidationErrorRegistration("score");
                return false;

            }
                      
        }    

    }
}
