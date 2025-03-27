using AcademyManagment.Domain.Enums;
using AcademyMenagment.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagment.Domain.Models
{
    public class User : BaseEntity
    {
        private string password1;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }

        public User(string firstName, string lastName, string username, string password, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Username = username;
            Password = password;
        }
        public User(string userName, string password)
        {
            Username = userName;
            Password = password;
        }

        public User(string userName, string password, string username, string password1) : this(userName, password)
        {
            Username = username;
            this.password1 = password1;
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

    }
}
