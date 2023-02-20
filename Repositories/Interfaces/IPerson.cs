using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BengansBowlingApplikation.Repositories.Interfaces
{
    public interface IPerson
    {
        int Id { get; set; }    
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        string Adress { get; set; }
        string PersonalNumber { get; set; }
        int Score { get; set; }
    }
}
