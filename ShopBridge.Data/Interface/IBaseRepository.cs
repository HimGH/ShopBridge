using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBridge.Data
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<TEntity> Get(string id);
        Task<TEntity> Get(int id);
        Task<IEnumerable<TEntity>> GetAll();
        Task Add(TEntity entity);
        Task Delete(TEntity entity);
        Task Update(TEntity entity);
    }
}
