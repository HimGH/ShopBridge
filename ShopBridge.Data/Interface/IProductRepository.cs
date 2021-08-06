using ShopBridge.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBridge.Data
{
    public interface IProductRepository:IBaseRepository<Product>
    {
        Task<Product> GetProductById(string id);
        //Task<IQueryable<Product>> GetAll();
        Task AddProduct(Product product);
        //Task<bool> Delete(int id);
        //Task<bool> Update(Product product);
    }
}
