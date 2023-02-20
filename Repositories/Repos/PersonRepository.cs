using BengansBowlingApplikation.Models;
using BengansBowlingApplikation.Repositories.Interfaces;
using BengansBowlingApplikation.Repositories.Models;
using BengansBowlingApplikation.UIclasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BengansBowlingApplikation.Repositories.Repos
{
    public class PersonRepository : IPersonRepository
    {

        BengansBowlingEntities1 _db;

        public PersonRepository()
        {
            _db = new BengansBowlingEntities1();
        }

        public void AddPerson(IPerson person)
        {           
            UserTable user = new UserTable();
            user.FirstName = person.FirstName;
            user.LastName = person.LastName;
            user.Email = person.Email;
            user.Adress = person.Adress;
            user.PersonalNumber = person.PersonalNumber;
            user.Score = person.Score;
          
            _db.UserTable.Add(user);
            _db.SaveChanges();           
        }
   
        public IPerson GetPerson(string email)
        {          
           UserTable person = _db.UserTable.Where(u => u.Email == email).FirstOrDefault();

            if (person == null)
            {
                return null;
            }

            List<string> list = new List<string>();
            list.Add(person.FirstName);
            list.Add(person.LastName);
            list.Add(person.Email);
            list.Add(person.Adress);
            list.Add(person.PersonalNumber);
            IPerson user = Factory.Factory.CreatePerson(list);
            user.Id = person.UserNumber;
            return user;
        }

        public void UpdatePersonScore(string email, int score)
        {
            //string email = personWinner[0];
            //int score = Convert.ToInt32(personWinner[1]);

            UserTable oldUser = _db.UserTable.Where(u => u.Email == email).SingleOrDefault();          
            oldUser.Score = oldUser.Score + score;
            _db.SaveChanges();     
            
        }

        public List <IPerson> GetScoreList()
        {
            List <UserTable> scoreList = _db.UserTable.Where(x => x.Score == x.Score).OrderByDescending(x => x.Score).ToList();

            List<string> list = new List<string>();

            IPerson person;
            List <IPerson> newScoreList = new List<IPerson>();

            foreach (UserTable user in scoreList)
            {
                list.Add(user.FirstName);
                list.Add(user.LastName);
                list.Add(user.LastName);
                list.Add(user.Email);
                list.Add(user.Adress);
                list.Add(user.PersonalNumber);
                person = Factory.Factory.CreatePerson(list);
                person.Score = user.Score;
                newScoreList.Add(person);
                list.Clear();
            }
                 
            return newScoreList;
        }
    }

   
}
