// Author: Chris Morgan
// The purpose of the ProductTypeDetailsViewModel is to contain all the necessary properties for rendering the product type details view. The requirements are to show the product type name as well as a list of products that are of the product

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bangazon.Models.ProductTypeViewModels
{
    public class ProductTypeDetailsViewModel
    {
        public ProductType ProductType { get; set; }

        public List<Product> Products { get; set; }

    }
}
