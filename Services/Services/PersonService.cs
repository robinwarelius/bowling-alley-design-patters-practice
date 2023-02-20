using BengansBowlingApplikation.Classes.Logger;
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
    public class PersonService : IPersonService
    {
        IPersonRepository _personRepo;
        BengansBowlingEntities1 _db;

        public PersonService(IPersonRepository registrationRepo)
        {
            _personRepo = registrationRepo;
            _db = new BengansBowlingEntities1();
        }

        public PersonService(){}

        public void AddPerson(IPerson person)
        {
            if (PersonValidator(person))
            {
                StandardMessages.DisplayValidationSuccesRegistration("member");
                _personRepo.AddPerson(person);
            }
        }

        private bool PersonValidator(IPerson person)
        {
            if (person.FirstName == "" || person.FirstName.Contains(" "))
            {
                StandardMessages.DisplayValidationErrorRegistration("firstname");
                return false;
            }
            if (person.LastName == "" || person.LastName.Contains(" "))
            {
                StandardMessages.DisplayValidationErrorRegistration("lastname");
                return false;
            }
            if (person.Email == "" || person.Email.Contains(" ") || !person.Email.Contains("@"))
            {
                StandardMessages.DisplayValidationErrorRegistration("email");
                return false;
            }
            if (person.Adress == "")
            {
                StandardMessages.DisplayValidationErrorRegistration("adress");
                return false;
            }
            if (person.PersonalNumber == "" || person.PersonalNumber.Contains(" "))
            {
                StandardMessages.DisplayValidationErrorRegistration("personal identity number");
                return false;
            }

            UserTable userExist = _db.UserTable.Where(u => u.Email == person.Email).FirstOrDefault();
            if (userExist != null)
            {
                StandardMessages.DisplayValidationErrorRegistration("input. Email already exist");
                return false;
            } 

            return true;
        }

        public IPerson GetPerson(string email)
        {               
            IPerson person = _personRepo.GetPerson(email);

            if (person == null)
            {
                StandardMessages.DisplayValidationErrorRegistration("email");
                return null;
            }

            return person;                           
        }

        public List <IPerson> GetScoreList()
        {
            List <IPerson> personsScore = _personRepo.GetScoreList();
            return personsScore;

        }

        public void UpdatePersonScore(string email, int score)
        {        
            
            UserTable userExist = _db.UserTable.Where(u => u.Email == email).FirstOrDefault();
            
            if (userExist == null)
            {
                StandardMessages.DisplayValidationErrorRegistration("email/score");
            }         
            else
            {
                _personRepo.UpdatePersonScore(email, score);
                StandardMessages.DisplayValidationSuccesRegistration("score");
            }          
                                                          
        }
    }
}
