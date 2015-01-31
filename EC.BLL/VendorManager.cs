using EC.Model;
using EC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC.BLL
{
    public class VendorManager : IVendorManager
    {
       // private UnitOfWork unitOfWork = new UnitOfWork();D:\Mahedee\CW-Project\EC.BLL\VendorManager.cs

        private IGenericRepository<Vendor> repository = null;

        public VendorManager()
        {
            this.repository = new GenericRepository<Vendor>();
        }


        public void AddVendor(Vendor vendor)
        {
            repository.Insert(vendor);
            repository.Save();
        }

        public List<Vendor> GetAllVendors()
        {
            return repository.SelectAll().ToList();
        }

        public Vendor GetSingleVendor(int id)
        {
            return repository.SelectByID(id);
        }

        public void EditVendor(Vendor vendor)
        {
            repository.Update(vendor);
            repository.Save();
        }

        public void RemoveVendor(int id)
        {
            repository.Delete(id);
            repository.Save();
        }


    }
}
