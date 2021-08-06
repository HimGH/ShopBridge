using Microsoft.AspNetCore.Mvc;
using ShopBridge.Data;
using ShopBridge.Entities;
using ShopBridge.Logic;
using ShopBridge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridge.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private IProductLogic _productLogic;
        public ProductController(IProductLogic productLogic)
        {
            _productLogic = productLogic;
        }
        [HttpGet]
        [Route("api/Product/Get")]
        public async Task<ApiResponseModel> Get(string id)
        {
            return await _productLogic.GetProductbyId(id);
        }
        [HttpPost]
        [Route("api/Product/PostProduct")]
        public async Task<ApiResponseModel> PostProduct([FromBody]Product productModel)
        {
            return await _productLogic.PostProduct(productModel);
        }
    }
}
