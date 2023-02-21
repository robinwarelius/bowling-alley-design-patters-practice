using BengansBowlingApplikation.Models;
using BengansBowlingApplikation.Repositories.Interfaces;
using BengansBowlingApplikation.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace BengansBowlingApplikation.Repositories.Repos
{
    public class ContestRepository : IContestRepository
    {
        BengansBowlingEntities1 _db;

        public ContestRepository()
        {
            _db = new BengansBowlingEntities1(); 
        }

      
        public void AddContest(IContest contest)
        {
            ContestTable match = new ContestTable();
            match.ContestDate = contest.Date;
            match.ContestTime = contest.Time;
         
            _db.ContestTable.Add(match);
            _db.SaveChanges();
        }

        public IContest GetContest()
        {
            ContestTable contest = _db.ContestTable.Where(d => d.ContestDate == d.ContestDate).OrderBy(d => d.ContestDate).FirstOrDefault();
            List <string> list = new List<string>();
            list.Add(contest.ContestDate.ToString());
            list.Add(contest.ContestTime.ToString());
            IContest match = Factory.Factory.CreateContest(list);
            match.Id = contest.ContestNumber;
            return match;
        }

        


    }
}
