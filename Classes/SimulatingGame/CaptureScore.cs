using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BengansBowlingApplikation.Classes.SimulatingGame
{
    public static class CaptureScore
    {
        public static void Game(List<string> name, List<string> email)
        {

            Console.WriteLine("\nPress enter to play round 1");
            Console.ReadLine();
            int[] score01 = Sets.Round(name);

            Console.WriteLine("\nPress enter to play round 2");
            Console.ReadLine();
            int[] score02 = Sets.Round(name);

            Console.WriteLine("\nPress enter to play round 3");
            Console.ReadLine();
            int[] score03 = Sets.Round(name);

            List<int> finalScore = new List<int>();
            for (int i = 0; i < name.Count; i++)
            {
                finalScore.Add(score01[i] + score02[i] + score03[i]);
            }

            Console.WriteLine("\nGAME OVER - End Result");
            for (int i = 0; i < name.Count; i++)
            {
                Console.WriteLine($"{name[i]} : {finalScore[i]}");
            }

            UpdatingUserScore.UpdateScore(finalScore, email);



        }
    }
}
