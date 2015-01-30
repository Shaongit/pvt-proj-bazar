using EC.Model;
using EC.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC.BLL
{
    public interface IUserManager
    {
        void AddUser(UserProfile user);
        List<UserProfile> GetAllUsers();
        UserProfile GetSingleUser(int id);
        void EditUser(UserProfile user);
        void RemoveUser(int id);

        UserProfile GetUser(string username);
    }
}
