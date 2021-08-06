using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBridge.Data
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly ShopBridgeDBContext _context;
        public BaseRepository(ShopBridgeDBContext context)
        {
            _context = context;
        }


        public async Task<TEntity> Get(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }
        public async Task<TEntity> Get(string id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            List<TEntity> entities =  _context.Set<TEntity>().ToList();
            return  entities;
        }

        public async Task Add(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
        }

        public async Task Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }

        public async Task Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
        }
      
    }
}
