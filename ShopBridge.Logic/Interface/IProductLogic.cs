using ShopBridge.Entities;
using ShopBridge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBridge.Logic
{
   
    public interface IProductLogic
    {
        Task<ApiResponseModel> GetProductbyId(string Id);
        Task<ApiResponseModel> PostProduct(Product productModel);
    }
}
