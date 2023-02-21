using BengansBowlingApplikation.Models;
using BengansBowlingApplikation.Repositories.Interfaces;
using BengansBowlingApplikation.Repositories.Models;
using BengansBowlingApplikation.Repositories.Repos;
using BengansBowlingApplikation.Services.Interfaces;
using BengansBowlingApplikation.Services.Services;
using BengansBowlingApplikation.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BengansBowlingApplikation.Factory
{
    public static class Factory
    {
      
        public static IPerson CreatePerson(List<string> person)
        {
            return new Person(person[0], person[1], person[2], person[3], person[4], 0);
        }

        public static IPersonService CreatePersonService()
        {
            return new PersonService (CreatePersonRepository());
        }

        public static IPersonRepository CreatePersonRepository()
        {
            return new PersonRepository();
        }

        public static IContest CreateContest (List<string> contest)
        {
            return new Contest(contest[0], contest[1]);
        }

        public static IContestService CreateContestService()
        {
            return new ContestService(CreateContestReppository());
        }

        public static IContestRepository CreateContestReppository()
        {
            return new ContestRepository();
        }

        
        public static IBooking CreateBooking(IPerson person, IContest contest)
        {
            return new Booking(person, contest);

        }

        public static IBookingService CreateBookingService ()
        {
            return new BookingService(CreateBookingRepository());
        }

        public static IBookingRepository CreateBookingRepository()
        {
            return new BookingRepository();
        }
      
    }
}
