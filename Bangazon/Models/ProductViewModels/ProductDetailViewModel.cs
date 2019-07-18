using Bangazon.Models;
using Bangazon.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bangazon.Models.ProductViewModels
{
  public class ProductDetailViewModel
  {
    public Product Product { get; set; }

    public List<OrderProduct> OrderProducts { get; set; }

    [Display(Name="Quantity Remaining")]
    public int QuantityRemaining { get
            {
                return Product.Quantity - OrderProducts.Count;
            } }
  }
}