using EC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EC.Repository
{
    public interface IVendorRepository : IDisposable
    {
        IQueryable<Vendor> All { get; }
        IQueryable<Vendor> AllIncluding(params Expression<Func<Vendor, object>>[] includeProperties);
        Vendor Find(int id);
        void InsertOrUpdate(Vendor vendor);
        void Delete(int id);
        void Save();
    }
}
