using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BengansBowlingApplikation.Repositories.Interfaces
{
    public interface IContest
    {
        string Date { get; set; }
        string Time { get; set; }

        int Id { get; set; }
    }
}
