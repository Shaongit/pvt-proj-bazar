using EC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC.BLL
{
    public interface ICityManager
    {
        void AddCity(City city);
        List<City> GetAllCity();
        City GetSingleCity(int id);
        void EditCity(City city);
        void RemoveCity(int id);
    }
}
