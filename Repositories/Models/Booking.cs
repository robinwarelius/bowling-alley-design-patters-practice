using BengansBowlingApplikation.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BengansBowlingApplikation.Repositories.Models
{
    public class Booking : IBooking
    {
        public int Id { get; set; }
        public int UserNumber { get; set; }
        public int ContestNumber { get; set; }

        public Booking(int userNumber, int contestNumber)
        {
            UserNumber = userNumber;
            ContestNumber = contestNumber;
        }
        public Booking(int id, int userNumber, int contestNumber) : this(id, userNumber)
        {
            ContestNumber = contestNumber;
        }
    }
}
