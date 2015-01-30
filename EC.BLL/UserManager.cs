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
    public class UserManager
    {
        private SecurityRepository repository = null;

        public UserManager()
        {
            this.repository = new SecurityRepository();
        }


        public UserProfile GetUser(string username)
        {
            return repository.GetUser(username);
        }
    }
}
