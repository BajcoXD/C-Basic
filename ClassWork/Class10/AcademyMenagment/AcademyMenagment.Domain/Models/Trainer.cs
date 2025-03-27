using AcademyManagment.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AcademyManagment.Domain.Models
{
    public class Trainer : User
    {
        public Trainer(string firstName, string lastName, string username, string password, int age) : base(firstName, lastName, username, password, age)
        {
            Role = Role.Trainer;
        }
        public Trainer(string username, string password) : base(username, password)
        {
            Role = Role.Trainer;
        }
    }
}
}
