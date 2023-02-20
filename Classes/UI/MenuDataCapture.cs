using BengansBowlingApplikation.Classes.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BengansBowlingApplikation.UIclasses
{
    public static class MenuDataCapture
    {
        public static int MenuOptions()
        {
            try
            {
                int choice = 0;
                Console.WriteLine("1. Registrera Medlem");
                Console.WriteLine("2. Registrera Tävling");
                Console.WriteLine("3. Registrera Tävlingsdeltagare");
                Console.WriteLine("4. Registrera Tävlingsresultat");
                Console.WriteLine("5. Poängställning");
                Console.WriteLine("6. Simulera Match");
                choice = Convert.ToInt32(Console.ReadLine());
                return choice;
            } catch (Exception ex)
            {
                Logger.WriteLog(ex.Message);
                return 0;               
            }
            

        }
    }
}
