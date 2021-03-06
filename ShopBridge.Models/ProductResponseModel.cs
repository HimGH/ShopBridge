using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBridge.Models
{
   public class ProductResponseModel
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int ProductNumber { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int DiscountPercentage { get; set; }
        public int FlagDiscount { get; set; }
        public string ProductType { get; set; }
    }
}
