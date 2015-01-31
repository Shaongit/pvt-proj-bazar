using EC.Context;
using EC.Model.Entities;
using EC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC.BLL
{
    public class UserManager : IUserManager
    {
        private SecurityRepository securityRepository = null;
        
         private IGenericRepository<UserProfile> repository = null;


        public UserManager()
        {
            this.repository = new GenericRepository<UserProfile>();
            this.securityRepository = new SecurityRepository();
        }


        public UserProfile GetUser(string username)
        {
            return securityRepository.GetUser(username);
        }


        public void AddUser(UserProfile user)
        {
            throw new NotImplementedException();
        }

        public List<UserProfile> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public UserProfile GetSingleUser(int id)
        {
            return repository.SelectByID(id);
        }

        public void EditUser(UserProfile user)
        {
            repository.Update(user);
            repository.Save();
        }

        public void RemoveUser(int id)
        {
            throw new NotImplementedException();
        }
    }
}
