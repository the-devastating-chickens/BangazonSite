/* Author: Billy Mathison
 * Purpose: Creating a view model for products including product, a list of product types, and a list of select list items for ProductType dropdown.
 * */

using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bangazon.Models.ProductViewModels
{
    public class ProductCreateViewModel
    {
        public Product Product { get; set; }
        public List<ProductType> ProductTypes { get; set; }
        public List<SelectListItem> ProductTypeOptions => ProductTypes?.Select(p => new SelectListItem(p.Label, p.ProductTypeId.ToString())).ToList();
    }
}
