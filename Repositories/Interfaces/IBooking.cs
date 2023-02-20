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
        int UserNumber { get; set; }
        int ContestNumber { get; set; }

    }
}
