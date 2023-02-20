using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BengansBowlingApplikation.Classes.SimulatingGame
{
    public static class Sets
    {
        public static int[] Round(List<string> name)
        {
            Random random = new Random();

            int[] score = new int[name.Count];
            for (int i = 0; i < name.Count; i++)
            {
                score[i] = random.Next(0, 300);
            }

            Console.WriteLine("RESULT");
            for (var i = 0; i < name.Count; i++)
            {
                Console.WriteLine(name[i] + ": " + score[i]);
            }

            return score;
        }
    }
}
