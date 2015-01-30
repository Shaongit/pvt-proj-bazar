using EC.Model;
using EC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC.BLL
{
    public class ProductManager :IProductManager
    {
        private IGenericRepository<Product> repository = null;

        public ProductManager()
        {
            this.repository = new GenericRepository<Product>();
        }

        public void AddProduct(Product Product)
        {
            repository.Insert(Product);
            repository.Save();
        }

        public List<Product> GetAllProducts()
        {
            return repository.SelectAll().ToList();
        }

        public Product GetSingleProduct(int id)
        {
            return repository.SelectByID(id);
        }

        public void EditProduct(Product Product)
        {
            repository.Update(Product);
            repository.Save();
        }

        public void RemoveProduct(int id)
        {
            repository.Delete(id);
            repository.Save();
        }
    }
}
