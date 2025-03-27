using AcademyManagement.Domain;
using AcademyManagment.Domain.Enums;
using AcademyManagment.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagment.Domain
{
    public class DataAccess
    {
        private Database _database;
        public DataAccess()
        {
            _database = new Database();
        }
        public Admin GetAdmin(string username, string password)
        {
            Admin adminFromDb = _database.Admins.FirstOrDefault(x => x.Username.ToLower().Trim() == username.ToLower().Trim() || x.Password == password);
            return adminFromDb;
        }
        public Trainer GetTrainer(string username, string password)
        {
            Trainer trainerFromDb = _database.Trainers.FirstOrDefault(x => x.Username.ToLower().Trim() == username.ToLower().Trim() || x.Password == password);
            return trainerFromDb;
        }
        public Trainer GetStudent(string username, string password)
        {
            Trainer studentFromDb = _database.Trainers.FirstOrDefault(x => x.Username.ToLower().Trim() == username.ToLower().Trim() || x.Password == password);
            return studentFromDb;
        }
        public bool CheckIfUserExsists(string username, Role role)
        {
            switch (role)
            {
                case Role.Admin:
                    return _database.Admins.Any(x => x.Username.ToLower().Trim() == username.ToLower().Trim() );
                    break;
                case Role.Trainer:
                    return _database.Trainers.Any(x => x.Username.ToLower().Trim() == username.ToLower().Trim());
                    break;
                case Role.Student:
                    return _database.Students.Any(x => x.Username.ToLower().Trim() == username.ToLower().Trim());
                    break;
                default:
                    return false;
            }
        }
        public List<string> GetUsernames(Role role, Admin loggedAdmin)
        {
            switch (role)
            {
                case Role.Admin:
                    return _database.Admins.Where(x => x.Username != loggedAdmin.Username).Select(x => x.Username).ToList();
                case Role.Trainer:
                    return _database.Trainers.Select(x => x.Username).ToList();
                case Role.Student:
                    return _database.Students.Select(x => x.Username).ToList();
                default:
                    throw new Exception($"Error occured while retriving username from database!");
            }
        }
        public void CreateNewUser(string username, string password, Role role)
        {
            switch (role)
            {
                case Role.Admin:
                    Admin newAdmin = new Admin(username, password);
                    _database.Admins.Add(newAdmin);
                    break;
                case Role.Trainer:
                    Trainer newTrainer = new Trainer(username, password);
                    _database.Trainers.Add(newTrainer);
                    break;
                case Role.Student:
                    Student newStudent = new Student(username, password);
                    _database.Students.Add(newStudent);
                    break;
                default:
                    throw new Exception($"Error occured while saving new user to database.");
            }
        }
        public bool DeleteUser(string username, Role role)
        {
            switch (role)
            {
                case Role.Admin:
                    Admin adminDb = _database.Admins.FirstOrDefault(x => x.Username.ToLower().Trim() == username);
                    return _database.Admins.Remove(adminDb);
                case Role.Trainer:
                    Trainer trainerDb = _database.Trainers.FirstOrDefault(x => x.Username.ToLower().Trim() == username);
                    return _database.Trainers.Remove(trainerDb);
                case Role.Student:
                    Student studentDb = _database.Students.FirstOrDefault(x => x.Username.ToLower().Trim() == username);
                    return _database.Students.Remove(studentDb);
                default:
                    return false;
            }
        }

    }
}
