using System;
using System.ComponentModel.DataAnnotations;

namespace ShopBridge.Entities
{
    /// <summary>
    /// Product Entity
    /// </summary>
    public class Product
    {
      
        [Key]
        public string ProductId { get; set; }
        public string ProductTypeId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int ProductNumber { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int DiscountPercentage { get; set; }
        public int FlagDiscount { get; set; }
    }
}