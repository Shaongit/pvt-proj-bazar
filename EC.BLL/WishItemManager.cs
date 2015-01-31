using EC.Model;
using EC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC.BLL
{
    public class WishItemManager
    {
        private IGenericRepository<WishItem> repository = null;

        public WishItemManager()
        {
            this.repository = new GenericRepository<WishItem>();
        }


        public List<WishItem> GetUserWishItems(int userId)
        {
            return repository.SelectAll().Where(p => p.UserId == userId).ToList();
        }
    }
}
