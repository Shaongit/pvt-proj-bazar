using EC.Context;
using EC.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC.Repository
{
    public class SecurityRepository
    {
        ECommerceContext context = new ECommerceContext();

        public SecurityRepository()
            : this(new ECommerceContext())
        {

        }

        public SecurityRepository(ECommerceContext context)
        {
            this.context = context;
        }


        public UserProfile GetUser(string username)
        {
            return this.context.UserProfiles.Where(Usr => Usr.UserName == username).FirstOrDefault();
        }

        //public IQueryable<Vendor> All
        //{
        //    get { return context.Vendors; }
        //}
    }
}
