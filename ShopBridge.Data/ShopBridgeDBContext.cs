using Microsoft.EntityFrameworkCore;
using ShopBridge.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBridge.Data
{
    public partial class ShopBridgeDBContext : DbContext
    {
        //public ShopBridgeDBContext _shopBridgeDBContext;
        //public ShopBridgeDBContext(ShopBridgeDBContext ShopBridgeDBContext)
        //{
        //    _shopBridgeDBContext = ShopBridgeDBContext;
        //}
        public ShopBridgeDBContext()
        {

        }
        public ShopBridgeDBContext(DbContextOptions<ShopBridgeDBContext> options) : base(options)
        {
        }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductType> ProductType { get; set; }
        public DbSet<Sale> Sale { get; set; }
    }
}
