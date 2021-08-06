using ShopBridge.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBridge.Data
{
    public class ProductTypeRepository : BaseRepository<ProductType>, IProductTypeRepository
    {
        //UnitOfWork _unitOfWork;
        public ProductTypeRepository(ShopBridgeDBContext shopBridgeDBContext) : base(shopBridgeDBContext)
        {

        }

    }
}
