using ShopBridge.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBridge.Data
{
    public interface IProductTypeRepository:IBaseRepository<ProductType>
    {
        //Task<ProductType> Get(int id);
        //Task<IQueryable<ProductType>> GetAll();
        //Task<int> Add(ProductType product);
        //Task<bool> Delete(int id);
        //Task<bool> Update(ProductType product);
    }
}
