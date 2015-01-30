using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EC.Model;

namespace EC.BLL
{
    public interface IProductManager
    {
        void AddProduct(Product Product);
        List<Product> GetAllProducts();
        Product GetSingleProduct(int id);
        void EditProduct(Product Product);
        void RemoveProduct(int id);
    }
}
