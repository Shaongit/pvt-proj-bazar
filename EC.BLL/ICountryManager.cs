using EC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC.BLL
{
    public interface ICountryManager
    {
        void AddVendor(Country country);
        List<Country> GetAllCountry();
        Country GetSingleCountry(int id);
        void EditCountry(Country country);
        void RemoveCountry(int id);
    }
}
