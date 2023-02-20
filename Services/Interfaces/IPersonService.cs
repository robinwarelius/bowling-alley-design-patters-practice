using BengansBowlingApplikation.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BengansBowlingApplikation.Services.Interfaces
{
    public interface IPersonService
    {
        void AddPerson(IPerson person);
        IPerson GetPerson(string email);
        void UpdatePersonScore(string email, int score);
        List <IPerson> GetScoreList();
    }
}
