using EC.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EC.Repository
{
    public class UnitOfWork : IDisposable
    {

        private ECommerceContext context;

        public UnitOfWork()
        {
            context = new ECommerceContext();
        }

        public UnitOfWork(ECommerceContext _context)
        {
            this.context = _context;
        }

        private VendorRepository _vendorRepository;

        public VendorRepository VendorRepository
        {
            get
            {

                if (this._vendorRepository == null)
                {
                    this._vendorRepository = new VendorRepository(context);
                }
                return _vendorRepository;
            }
        }

        public void Dispose()
        {
            context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}