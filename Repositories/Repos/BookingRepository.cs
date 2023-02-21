using BengansBowlingApplikation.Models;
using BengansBowlingApplikation.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BengansBowlingApplikation.Repositories.Repos
{
    public class BookingRepository : IBookingRepository
    {
        BengansBowlingEntities1 _db;

        public BookingRepository()
        {
            _db = new BengansBowlingEntities1();
        }

        public void AddBooking(IBooking booking)
        {
            BookTable book = new BookTable();
            book.UserNumber = booking.person.Id;
            book.ContestNumber = booking.contest.Id;

            _db.BookTable.Add(book);
            _db.SaveChanges();           
        }

        public int GetBooking()
        {
            BookTable booking = _db.BookTable.Where(b => b.BookNumber == b.BookNumber).OrderByDescending(b => b.ContestNumber).FirstOrDefault();
            if (booking == null)
            {
                return 0;
            }

            return booking.BookNumber;
            



        }
    }
}
