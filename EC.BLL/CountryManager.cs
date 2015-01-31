using EC.Model;
using EC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC.BLL
{
    public class CountryManager : ICountryManager
    {
         private IGenericRepository<Country> repository = null;

         public CountryManager()
        {
            this.repository = new GenericRepository<Country>();
        }

        public void AddVendor(Model.Country country)
        {
            throw new NotImplementedException();
        }

        public List<Country> GetAllCountry()
        {
            return repository.SelectAll().ToList();
        }

        public Model.Country GetSingleCountry(int id)
        {
            throw new NotImplementedException();
        }

        public void EditCountry(Model.Country country)
        {
            throw new NotImplementedException();
        }

        public void RemoveCountry(int id)
        {
            throw new NotImplementedException();
        }
    }
}
