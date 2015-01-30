using EC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC.BLL
{
    public interface IVendorManager
    {
        void AddVendor(Vendor vendor);
        List<Vendor> GetAllVendors();
        Vendor GetSingleVendor(int id);
        void EditVendor(Vendor vendor);
        void RemoveVendor(int id);
    }
}
