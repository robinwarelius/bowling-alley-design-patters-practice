using BengansBowlingApplikation.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BengansBowlingApplikation.Services.Interfaces
{
    public interface IBookingService
   {
        void AddBooking(IBooking booking);
        int GetBooking();
    }
}
