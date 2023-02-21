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
        public IPerson person { get; set; }
        public IContest contest { get; set; }

        public Booking(IPerson person, IContest contest)
        {
            this.person = person;
            this.contest = contest;
        }

        
    }
}
