using AcademyManagment.Domain;
using AcademyManagment.Domain.Enums;
using AcademyManagment.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagment.Services.UserServices
{
    public class AdminService
    {

        // login
        private DataAccess _dataAccess;
        public AdminService()
        {
            _dataAccess = new DataAccess();
        }
        public Admin AdminLogin(string username, string password)
        {
            Admin adminFromDb = _dataAccess.GetAdmin(username, password);
            if (adminFromDb == null)
            {
                throw new Exception($"Invalid credentionals entered. Try again@");
            }
            return adminFromDb;
        }
        // create user
        public void CreateUser(string username, string password, Role role)
        {
            bool userExsists = _dataAccess.CheckIfUserExsists(username, role);
            if (userExsists)
            {
                throw new Exception($"{role} with {username} allready exsists.");
            }
            _dataAccess.CreateNewUser(username, password, role);

        }
        // get users to remove
        public List<string> GetUsersToRemove(Role role, Admin loggedAdmin)
        {
            return _dataAccess.GetUsernames(role, loggedAdmin);
        }
        // Delete user
        public void DeleteUser(string username, Role role)
        {
            bool userExsists = _dataAccess.CheckIfUserExsists(username, role);
            if (!userExsists)
            {
                throw new Exception($"User allready doesnt exsists!");
            }
            _dataAccess.DeleteUser(username, role);
        }

    }
}
