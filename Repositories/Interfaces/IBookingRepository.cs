using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BengansBowlingApplikation.Repositories.Interfaces
{
    public interface IBookingRepository
    {
        void AddBooking(IBooking booking);
        int GetBooking();
    }
}
