using ShopBridge.Entities;
using System.Threading.Tasks;
namespace ShopBridge.Logic
{
    public interface IProductTypeLogic
    {
        Task<ProductType> GetProductTypebyId(string TypeId);
    }
}

