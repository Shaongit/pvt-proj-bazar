using EC.Model;
using EC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC.BLL
{
    public class CityManager : ICityManager
    {
         private IGenericRepository<City> repository = null;

         public CityManager()
        {
            this.repository = new GenericRepository<City>();
        }

        public void AddCity(Model.City city)
        {
            throw new NotImplementedException();
        }

        public List<Model.City> GetAllCity()
        {
            return repository.SelectAll().ToList();
        }

        public Model.City GetSingleCity(int id)
        {
            throw new NotImplementedException();
        }

        public void EditCity(Model.City city)
        {
            throw new NotImplementedException();
        }

        public void RemoveCity(int id)
        {
            throw new NotImplementedException();
        }
    }
}
