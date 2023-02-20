using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BengansBowlingApplikation.Repositories.Interfaces
{
    public interface IContestRepository
    {
        void AddContest(IContest contest);
        IContest GetContest();
    }
}
