using BengansBowlingApplikation.Repositories.Interfaces;
using BengansBowlingApplikation.Services.Interfaces;
using BengansBowlingApplikation.UIclasses;
using BengansBowlingApplikation.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BengansBowlingApplikation.Models;
using BengansBowlingApplikation.Repositories.Models;
using System.Runtime.InteropServices;
using BengansBowlingApplikation.Services.Services;
using BengansBowlingApplikation.Classes.UI;
using System.Xml.Schema;
using BengansBowlingApplikation.Classes.Logger;
using BengansBowlingApplikation.Classes.SimulatingGame;


/* Design principles/patterns:
 - Factory Pattern = factory
 - Structural = services & repositories
 - Single Resposibility Principles = one module one purpose
 - Dependecy injection = one place where I create objects
 - Interface segregation = small and simple interfaces
 - Singleton = logger
 - DRY = minimum repetition */


namespace BengansBowlingApplikation
{
    internal class Program
    {
        static void Main(string[] args)
        {         
            while (true)
            {            
                int userChoice = StartMenu.Menu();

                if (userChoice == 1)
                {
                    List<string> person = PersonDataCapture.Capture();
                    IPerson user = Factory.Factory.CreatePerson(person);
                    IPersonService personService = Factory.Factory.CreatePersonService();
                    personService.AddPerson(user);
                }

                if (userChoice == 2)
                {
                    List<string> contest = ContestDataCapture.capture();
                    IContest game = Factory.Factory.CreateContest(contest);
                    IContestService registerContestService = Factory.Factory.CreateContestService();
                    registerContestService.AddContest(game);                                  
                }

                if (userChoice == 3)
                {
                    IContestService contestService = Factory.Factory.CreateContestService();
                    IContest contest = contestService.GetContest();
                    string participateEmail = CompetitionParticipantCapture.Capture(contest);                         
                    IPersonService personService = Factory.Factory.CreatePersonService();
                    IPerson person = personService.GetPerson(participateEmail);

                    if (person != null)
                    {
                        IBooking booking = Factory.Factory.CreateBooking(person, contest);
                        IBookingService bookingService = Factory.Factory.CreateBookingService();
                        bookingService.AddBooking(booking);
                    }                                                                                                                
                }

                if (userChoice == 4)
                {
                    List<string> winnerPerson = WinnerDataCapture.Capture();              
                    if (WinnerDataValidator.Validate(winnerPerson))
                    {
                        IPersonService personService = Factory.Factory.CreatePersonService();
                        personService.UpdatePersonScore(winnerPerson[0], Convert.ToInt32(winnerPerson[1]));
                    }                                                                      
                }

                if (userChoice == 5)
                {
                    IPersonService personService = Factory.Factory.CreatePersonService();
                    List <IPerson> scoreList = personService.GetScoreList();
                    StandardMessages.DisplayScore(scoreList);                                
                }        
                
                if (userChoice == 6)
                {
                    GameInformation.part01();
                }

            }

        }
    }
}
