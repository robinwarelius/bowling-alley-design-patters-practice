using BengansBowlingApplikation.Models;
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
    public class BookingService : IBookingService
    {
        IBookingRepository _bookingRepository;

        BengansBowlingEntities1 _db;

        public BookingService(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
            _db = new BengansBowlingEntities1();
        }

        public void AddBooking(IBooking booking)
        {

            if (GetBooking() > 10)
            {
                StandardMessages.DisplayValidationErrorBooking();
            }

            BookTable userEmailExist = _db.BookTable.Where(x => x.UserNumber == booking.person.Id).SingleOrDefault();
            if (userEmailExist != null)
            {
                StandardMessages.DisplayValidationErrorRegistration("email");
            }
            else
            {
                StandardMessages.DisplayValidationSuccesRegistration("booking");
                _bookingRepository.AddBooking(booking);
            }
         
        }

        public int GetBooking()
        {
            int amount = _bookingRepository.GetBooking();
            return amount;
        }
    }
}
