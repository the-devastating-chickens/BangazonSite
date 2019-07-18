using Bangazon.Models;
using Bangazon.Data;
using System.Collections.Generic;

namespace Bangazon.Models.ProductViewModels
{
  public class ProductDetailViewModel
  {
    public Product Product { get; set; }

    public List<OrderProduct> OrderProducts { get; set; }

    public int QuantityRemaining { get
            {
                return Product.Quantity - OrderProducts.Count;
            } }
  }
}