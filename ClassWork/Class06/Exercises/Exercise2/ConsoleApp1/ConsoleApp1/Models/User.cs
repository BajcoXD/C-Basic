

namespace ConsoleApp1.Models
{
    public class User
    {
        public User()
        {
            Id = GenerateId();
        }
        public User(string username, string password, string[] messages)
        {
            Username = username;
            Password = password;
            Messages = messages;
            Id = GenerateId();
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public string[] Messages { get; set; } 
        private long Id { get; set; }
        private long GenerateId()
        {
            return new Random().Next(100000, 999999); // gets a random number between the values given
        }
        public long GetSSN()
        {
            return Id;
        }
    }
}
