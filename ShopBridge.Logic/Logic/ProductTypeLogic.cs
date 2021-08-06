using ShopBridge.Data;
using ShopBridge.Entities;
using ShopBridge.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBridge.Logic
{
    public class ProductTypeLogic : BaseLogic, IProductTypeLogic
    {

        public ProductTypeLogic(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
        public async Task<ProductType> GetProductTypebyId(string Id)
        {
            return await _unitOfWork.ProductTypeRepository.Value.Get(Id);
        }
    }
}
