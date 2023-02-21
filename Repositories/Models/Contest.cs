using BengansBowlingApplikation.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BengansBowlingApplikation.Repositories.Models
{
    public class Contest : IContest
    {
        public string Date { get; set; }
        public string Time { get; set; }
        public int Id { get; set; }

        public Contest(string date, string time)
        {
            Date = date;
            Time = time;
        }

        public Contest(string date, string time, int id) : this(date, time)
        {
            Id = id;
        }
    }
}
