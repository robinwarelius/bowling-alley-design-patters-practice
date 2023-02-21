using BengansBowlingApplikation.UIclasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BengansBowlingApplikation.Classes.UI
{
   public static class StartMenu
    {
        public static int Menu()
        {
            bool userInput = false;
            int userChoice = 0;
            while (!userInput)
            {
                StandardMessages.WelcomeMessage();
                userChoice = MenuDataCapture.MenuOptions();
                bool validateChoice = MenuDataValidator.Validate(userChoice);

                if (validateChoice)
                {
                    
                    userInput = true;
                }
            }
            return userChoice;
        }
    }
}
