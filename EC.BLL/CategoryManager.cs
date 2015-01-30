using EC.Model;
using EC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC.BLL
{
    public class CategoryManager : ICategoryManager
    {
        private IGenericRepository<Category> repository = null;

        public CategoryManager()
        {
            this.repository = new GenericRepository<Category>();
        }

        public void AddCategory(Category objCategory)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAllCategories()
        {
            List<Category> lstCategory = new List<Category>();
            lstCategory = repository.SelectAll().Where(p => p.ParentCategoryId == 0).ToList();
            foreach (var objCategory in lstCategory)
            {
                objCategory.SubCategories = repository.SelectAll().Where(p => p.ParentCategoryId == objCategory.Id).ToList();
            }
            return lstCategory;
        }

        public Category GetSingleCategory(int id)
        {
            return repository.SelectByID(id);
        }

        public void EditCategory(Category category)
        {
            repository.Update(category);
            repository.Save();
        }

        public void RemoveCategory(int id)
        {
            repository.Delete(id);
            repository.Save();
        }
    }
}
