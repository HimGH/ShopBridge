using ShopBridge.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBridge.Data
{
    public   class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        private readonly ShopBridgeDBContext _context;
        public ProductRepository(ShopBridgeDBContext shopBridgeDBContext):base(shopBridgeDBContext)
        {
            _context = shopBridgeDBContext;
        }
        public async Task<Product> GetProductById(string id)
        {
            var product =  _context.Product.FirstOrDefault(x => x.ProductId == id);
            return product;
        }
        public async Task AddProduct(Product product)
        {
            await _context.Product.AddAsync(product);
        }

    }
}
