using EC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC.BLL
{
    public interface ICategoryManager
    {
        void AddCategory(Category objCategory);
        List<Category> GetAllCategories();
        Category GetSingleCategory(int id);
        void EditCategory(Category category);
        void RemoveCategory(int id);
    }
}
