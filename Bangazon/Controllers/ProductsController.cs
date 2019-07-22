using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Bangazon.Data;
using Bangazon.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Bangazon.Models.ProductViewModels;
namespace Bangazon.Controllers
{
    [Authorize]
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public ProductsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        // GET: Products
        public async Task<IActionResult> Index(string searchString, string searchBy)
        {
            ViewData["searchBy"] = searchBy;
            ViewData["CurrentFilter"] = searchString;

            var applicationDbContext = _context.Product.Where(p => p.Active == true).Include(p => p.ProductType).Include(p => p.User);

            //If user enters a string into the search input field in the navbar - adding a where clause to include products whose name contains string.
            if (!String.IsNullOrEmpty(searchString))
            {
                switch (searchBy)

                {
               
                    case "1":
                        applicationDbContext = _context.Product.Where(p => p.City.Contains(searchString)).Include(p => p.ProductType).Include(p => p.User);
                        break;
                    case "2":
                        applicationDbContext = _context.Product.Where(p => p.Title.Contains(searchString)).Include(p => p.ProductType).Include(p => p.User);
                        break;
                    default:
                        applicationDbContext = _context.Product.Where(p => p.Title.Contains(searchString) || p.City.Contains(searchString)).Include(p => p.ProductType).Include(p => p.User);
                        break;
                }
            }
            //This switch case statement uses the searchBy parameter which is in _Layout.cs and tells us what we want to be searching through.

            return View(await applicationDbContext.ToListAsync());
        }

        // GET: My Products
        public async Task<IActionResult> MyIndex()
        {
            var currentUser = await GetCurrentUserAsync();

            //Here we are using _context to go through our products and grab the ones where the userId of the product and the userId of the logged in user are the same. It also grabs the ones where the product boolean isActive is set to true,
            //which means that a user has not "deleted" the product (they still are in the database but not listed as available to purchase). 
            var applicationDbContext = _context.Product.Where(p => p.UserId == currentUser.Id && p.Active == true)
                //We are joining the ProductType table on to the Product table!
                .Include(p => p.ProductType)
                //And the User table as well! Wow!
                .Include(p => p.User);

            //Inside of this variable we are going through the applicationDbContext, which is a list of our active products
            //specific to our logged in user. For each product in this list, we instantiate a view model for that product's details.
            //In each instance, we are setting the product property of our view model to each product and setting the OrderProduct propety
            //to look into our OrderProduct and grab the ones where the ProductId property on the OrderProduct matches the primary key ProductId
            //on Product, and then converting it into a list.
            var enumerableViewModel = applicationDbContext.Select(p => new ProductDetailViewModel
            {
                Product = p,
                OrderProducts =  _context.OrderProduct.Where(op => op.ProductId == p.ProductId).ToList()
            });

            //Now we are passing  our variable enumerableViewModel that does all that exciting stuff listed above to our view!
            return View(enumerableViewModel);
        }

        // GET: Products/Details/5
        //Modified by Anne Vick. Now gets a list of orderProducts where the productId matches the id of the found product and that list along with the product in a product detail model view.
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //get product with a join table with productType and User.
            var product = await _context.Product
                .Where(p => p.Active == true)
                .Include(p => p.ProductType)
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            //Getting a list of orderProducts that are associated with the current product's Id.
            var orderProduct = await _context.OrderProduct
                .Where(o => o.ProductId == id).ToListAsync();

            //view model for product details.
            ProductDetailViewModel ViewModel = new ProductDetailViewModel();

            //add product and order product lists to the Product Detail View Model.
            ViewModel.Product = product;
            ViewModel.OrderProducts = orderProduct;

            //passes Detail View Model to the view.
            return View(ViewModel);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            //Building a list of product types with the intial value of null and no message to ensure user selects a category
            List<SelectListItem> productTypeItems = new SelectList(_context.ProductType, "ProductTypeId", "Label").ToList();
            productTypeItems.Insert(0, (new SelectListItem { Text = "", Value = null }));
            ViewData["ProductTypeId"] = productTypeItems;

            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int? id, [Bind("ProductId,DateCreated,Description,Title,Price,Quantity,UserId,City,ImagePath,Active,ProductTypeId")] Product product)
        {
            ModelState.Remove("User");
            ModelState.Remove("UserId");
            if (ModelState.IsValid)
            {
                var currentUser = await GetCurrentUserAsync();
                product.UserId = currentUser.Id;
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(MyIndex));
            }
            ViewData["ProductTypeId"] = new SelectList(_context.ProductType, "ProductTypeId", "Label", product.ProductTypeId);
            return View(product);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            var currentUser = await GetCurrentUserAsync();
            if (currentUser.Id != product.UserId)
            {
                return NotFound();
            }

            ViewData["ProductTypeId"] = new SelectList(_context.ProductType, "ProductTypeId", "Label", product.ProductTypeId);
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductId,DateCreated,Description,Title,Price,Quantity,UserId,City,ImagePath,Active,ProductTypeId")] Product product)
        {

            if (id != product.ProductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ProductId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(MyIndex));
            }
            ViewData["ProductTypeId"] = new SelectList(_context.ProductType, "ProductTypeId", "Label", product.ProductTypeId);
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var currentUser = await GetCurrentUserAsync();
            var product = await _context.Product
                            .Include(p => p.ProductType)
                            .Include(p => p.User)
                            .FirstOrDefaultAsync(m => m.ProductId == id);

            if (id == null)
            {
                return NotFound();
            }

            if (product == null)
            {
                return NotFound();
            }

            if (currentUser.Id != product.UserId)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SoftDeleteConfirmed(int id)
        {
            var product = await _context.Product.FindAsync(id);
            product.Active = false;

            try
            {
                _context.Product.Remove(product);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                _context.Update(product);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(MyIndex));
        }

        private bool ProductExists(int id)
        {
            return _context.Product.Any(e => e.ProductId == id);
        }
    }
}
