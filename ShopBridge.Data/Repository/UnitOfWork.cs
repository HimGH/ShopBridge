using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBridge.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ShopBridgeDBContext _context;
     public  Lazy<IProductRepository> ProductRepository { get; }
      public Lazy<IProductTypeRepository> ProductTypeRepository { get; }

        public UnitOfWork(ShopBridgeDBContext shopBridgeDBContext
           // ,
           //IProductRepository ProductRepository,
           // IProductTypeRepository ProductTypeRepository
            )
        {
            this._context = shopBridgeDBContext;
            this.ProductRepository = new  Lazy<IProductRepository>(()=> new ProductRepository(_context));
            this.ProductTypeRepository = new Lazy<IProductTypeRepository>(() => new ProductTypeRepository(_context));
        }
        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
    }

}
