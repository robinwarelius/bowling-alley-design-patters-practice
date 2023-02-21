using BengansBowlingApplikation.Classes.Logger;
using BengansBowlingApplikation.Repositories.Interfaces;
using BengansBowlingApplikation.Services.Interfaces;
using BengansBowlingApplikation.UIclasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BengansBowlingApplikation.Services.Services
{
    public class ContestService : IContestService
    {
        IContestRepository _registrationContestRepo;

        public ContestService(IContestRepository registrationContestRepo)
        {
            _registrationContestRepo = registrationContestRepo;
        }


        public void AddContest(IContest contest)
        {
            try
            {
                DateTime today = DateTime.Now;
                DateTime date = DateTime.Parse(contest.Date);
                if (date <= today || contest.Date == null || contest.Time == null)
                {
                    StandardMessages.DisplayValidationErrorRegistration("date/time");
                }
                else
                {
                    StandardMessages.DisplayValidationSuccesRegistration("contest");
                    _registrationContestRepo.AddContest(contest);
                }
            }
            catch (Exception ex)
            {
                StandardMessages.DisplayValidationErrorRegistration("date/time");
                Factory.Factory.CreateLogger(ex.Message);
            }
           

                  
        }

        public IContest GetContest()
        {
           IContest contestDateTime = _registrationContestRepo.GetContest();
           return contestDateTime;
        }
    }
}
