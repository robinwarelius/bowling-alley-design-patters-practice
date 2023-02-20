using BengansBowlingApplikation.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BengansBowlingApplikation.Repositories.Models
{
    public class Person : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public string PersonalNumber { get; set; }
        public int Score { get; set; }

        public Person(string firstName, string lastName, string email, string adress, string personalNumber, int score)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Adress = adress;
            PersonalNumber = personalNumber;
            Score = score;
        }
    }
}
