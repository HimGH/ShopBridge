using ShopBridge.Data;
using ShopBridge.Entities;
using ShopBridge.Logic;
using ShopBridge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBridge.Logic
{
    public class ProductLogic : BaseLogic, IProductLogic
    {

        public ProductLogic( IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            
        }

        public async Task<ApiResponseModel> PostProduct(Product productModel)
        {
            try
            {
                await _unitOfWork.ProductRepository.Value.AddProduct(productModel);
                _unitOfWork.Complete();
                return new ApiResponseModel { data = "Success", success = true };

            }
            catch (Exception)
            {
                return new ApiResponseModel { data = "Error", success = false };
            }

        }
        public async Task<ApiResponseModel> GetProductbyId(string Id)
        {
            try
            {
                Product product = await _unitOfWork.ProductRepository.Value.GetProductById(Id);
                ProductType productType = await _unitOfWork.ProductTypeRepository.Value.Get(product.ProductTypeId);

                ProductResponseModel productResponseModel = new ProductResponseModel()
                {
                    Description = product.Description,
                    DiscountPercentage = product.DiscountPercentage,
                    FlagDiscount = product.FlagDiscount,
                    Price = product.Price,
                    ProductName = product.ProductName,
                    ProductNumber = product.ProductNumber,
                    ProductType = productType.Type
                };
            return new ApiResponseModel { data = productResponseModel, success = true };

            }
            catch (Exception)
            {
                return new ApiResponseModel { data = "Error", success = false };
            }
        }
    }
}
