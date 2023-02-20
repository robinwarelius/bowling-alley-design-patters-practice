using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BengansBowlingApplikation.UIclasses
{
    public static class MenuValidator
    {
        public static bool Validate(int choice)
        {
            if (choice > 0 && choice < 7)
            {
                return true;
            }
            else
            {
                StandardMessages.DisplayValidationErrorMenu();
                return false;
            }

        }
    }
}
