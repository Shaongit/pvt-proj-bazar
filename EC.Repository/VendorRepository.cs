using EC.Context;
using EC.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Data.Entity;

namespace EC.Repository
{ 
    public class VendorRepository : IVendorRepository
    {
        ECommerceContext context = new ECommerceContext();

        public VendorRepository()
            : this(new ECommerceContext())
        {

        }

        public VendorRepository(ECommerceContext context)
        {
            this.context = context;
        }


        public IQueryable<Vendor> All
        {
            get { return context.Vendors; }
        }

        public IQueryable<Vendor> AllIncluding(params Expression<Func<Vendor, object>>[] includeProperties)
        {
            IQueryable<Vendor> query = context.Vendors;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public Vendor Find(int id)
        {
            return context.Vendors.Find(id);
        }

        public void InsertOrUpdate(Vendor vendor)
        {
            if (vendor.Id == default(int)) {
                // New entity
                context.Vendors.Add(vendor);
            } else {
                // Existing entity
                context.Entry(vendor).State = System.Data.Entity.EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var vendor = context.Vendors.Find(id);
            context.Vendors.Remove(vendor);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Dispose() 
        {
            context.Dispose();
        }
    }
}