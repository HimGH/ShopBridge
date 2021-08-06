using System;

namespace ShopBridge.Data
{
    public interface IUnitOfWork : IDisposable
    {
        Lazy<IProductRepository> ProductRepository { get; }
        Lazy<IProductTypeRepository> ProductTypeRepository { get; }
        int Complete();
    }
}
