using BengansBowlingApplikation.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BengansBowlingApplikation.Repositories.Interfaces
{
    public interface IBooking
    {
        int Id { get; set; }

        IPerson person { get; set; }

        IContest contest { get; set; }

        //int IPerson { get; set; }
        //int ContestNumber { get; set; }

    }
}
