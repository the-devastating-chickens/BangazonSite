using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Bangazon.Data;
using Bangazon.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace Bangazon.Controllers
{
    [Authorize]
    public class OrdersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;


        public OrdersController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        // Modified by Billy Mitchell. This controller pull all previous orders and current cart that are only associated with the currently logged in user.
        // GET: Orders
        public async Task<IActionResult> Index()
        {
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);
            var applicationDbContext = _context.Order.Include(o => o.PaymentType).Include(o => o.User).Where(o => o.UserId == currentUser.Id);
            return View(await applicationDbContext.ToListAsync());
        }

        // Modified by Billy Mitchell. This controller pull all previous orders and current cart that are only associated with the currently logged in user.
        // GET: Orders
        public async Task<IActionResult> OrderHistory()
        {
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);
            var applicationDbContext = _context.Order.Include(o => o.PaymentType).Include(o => o.User).Where(o => o.UserId == currentUser.Id && o.PaymentType != null);
            return View(await applicationDbContext.ToListAsync());
        }

        //Modified by Anne Vick. Now gets a list of orderProducts associated with the order's orderId.
        // GET: Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var currentUser = await GetCurrentUserAsync();

            //if no order Id is supplied, looks for the current order (no payment type), and if none is found, creates a new order.
            if (id == null)
            {
                //get a list of all orders from db.
                List<Order> orders = await _context.Order.ToListAsync();
                //find order that matches the user Id and has no payment type associated with it.
                Order currentOrder = null;

                if (orders != null)
                {
                    currentOrder = orders.Find(o => o.UserId == currentUser.Id && o.PaymentTypeId == null);
                }

                //if current order is found, return it in the view.
                if (currentOrder != null)
                {
                    var currentOrderProducts = await _context.OrderProduct
                        .Where(op => op.OrderId == currentOrder.OrderId).ToListAsync();

                    var currentOrderTotal = 0.0;

                    //get the Product for each orderProduct.
                    foreach (var item in currentOrderProducts)
                    {
                        item.Product = await _context.Product.FirstOrDefaultAsync(p => p.ProductId == item.ProductId);
                        currentOrderTotal += item.Product.Price;
                    }

                    //Add the list of orderProducts to the order.
                    currentOrder.OrderProducts = currentOrderProducts;
                    //add total
                    currentOrder.OrderTotal = currentOrderTotal;

                    return View(currentOrder);
                } else
                {
                    //if not found, creates a new order by calling the order create method and returning the IActionResult as its own result.
                    Order newOrder = new Order();
                    return await this.Create(newOrder);
                }
            }

            var order = await _context.Order
                .Include(o => o.PaymentType)
                .Include(o => o.User)
                .FirstOrDefaultAsync(m => m.OrderId == id);

            if (order == null)
            {
                return NotFound();
            }

            var orderProducts = await _context.OrderProduct
                .Where(o => o.OrderId == id).ToListAsync();

            var OrdertTotal = 0.0;

            //get the Product for each orderProduct.
            foreach (var item in orderProducts)
            {
                item.Product = await _context.Product.FirstOrDefaultAsync(p => p.ProductId == item.ProductId);
                OrdertTotal += item.Product.Price;
            }

            //Add the list of orderProducts to the order.
            order.OrderProducts = orderProducts;

            //Adding the price of each product together.
            order.OrderTotal = OrdertTotal;

            return View(order);
        }

        // GET: Orders/Create
        public IActionResult Create()
        {
            ViewData["PaymentTypeId"] = new SelectList(_context.PaymentType, "PaymentTypeId", "AccountNumber");
            ViewData["UserId"] = new SelectList(_context.ApplicationUsers, "Id", "Id");
            return View();
        }


        // POST: Orders/Create
        //To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderId,DateCreated,DateCompleted,UserId,PaymentTypeId")] Order order)
        {
            var currentUser = await GetCurrentUserAsync();

            if (ModelState.IsValid)
            {
                order.DateCreated = DateTime.Now;
                order.UserId = currentUser.Id;
                _context.Add(order);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", "Orders", new { id = order.OrderId });
            } else
            {
                return StatusCode(422);
            }
        }

        // GET: Orders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            var currentUser = await GetCurrentUserAsync();

            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Order
                        .Include(o => o.PaymentType)
                        .Include(o => o.User)
                        .FirstOrDefaultAsync(m => m.OrderId == id);

            if (order == null)
            {
                return NotFound();
            }

            if (order.PaymentType != null)
            {
                return NotFound();
            }

            if (order.UserId != currentUser.Id)
            {
                return NotFound();
            }

            ViewData["PaymentTypeId"] = new SelectList(_context.PaymentType, "PaymentTypeId", "AccountNumber", order.PaymentTypeId);
            ViewData["UserId"] = new SelectList(_context.ApplicationUsers, "Id", "Id", order.UserId);
            return View(order);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderId,PaymentTypeId")] Order order)
        {
            if (id != order.OrderId)
            {
                return NotFound();
            }

            ModelState.Remove("DateCreated");
            ModelState.Remove("DateCompleted");
            ModelState.Remove("UserId");
            ModelState.Remove("User");

            var currentUser = await GetCurrentUserAsync();

            if (ModelState.IsValid)
            {
                try
                {
                    order.UserId = currentUser.Id;
                    order.DateCompleted = DateTime.Now;
                    _context.Update(order);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderExists(order.OrderId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", new { id = order.OrderId });
            }
            ViewData["PaymentTypeId"] = new SelectList(_context.PaymentType, "PaymentTypeId", "AccountNumber", order.PaymentTypeId);
            ViewData["UserId"] = new SelectList(_context.ApplicationUsers, "Id", "Id", order.UserId);
            return View(order);
        }

        // GET: Orders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var currentUser = await GetCurrentUserAsync();

            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Order
                        .Include(o => o.PaymentType)
                        .Include(o => o.User)
                        .FirstOrDefaultAsync(m => m.OrderId == id);

            if (order.PaymentType != null)
            {
                return NotFound();
            }

            if (order.UserId != currentUser.Id)
            {
                return NotFound();
            }

            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var order = await _context.Order.FindAsync(id);
            _context.Order.Remove(order);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET Method that is the same as the Details method. This creates the view that allows the user to confirm clearing their shopping cart
        public async Task<IActionResult> ClearCart(int? id)
        {
            var currentUser = await GetCurrentUserAsync();

            //if no order Id is supplied, looks for the current order (no payment type), and if none is found, creates a new order.
            if (id == null)
            {
                //get a list of all orders from db.
                List<Order> orders = await _context.Order.ToListAsync();
                //find order that matches the user Id and has no payment type associated with it.
                Order currentOrder = orders.Find(o => o.UserId == currentUser.Id && o.PaymentTypeId == null);

                //if current order is found, return it in the view.
                if (currentOrder != null)
                {
                    var currentOrderProducts = await _context.OrderProduct
                        .Where(op => op.OrderId == currentOrder.OrderId).ToListAsync();

                    var currentOrderTotal = 0.0;

                    //get the Product for each orderProduct.
                    foreach (var item in currentOrderProducts)
                    {
                        item.Product = await _context.Product.FirstOrDefaultAsync(p => p.ProductId == item.ProductId);
                        currentOrderTotal += item.Product.Price;
                    }

                    //Add the list of orderProducts to the order.
                    currentOrder.OrderProducts = currentOrderProducts;
                    //add total
                    currentOrder.OrderTotal = currentOrderTotal;

                    return View(currentOrder);
                }
                else
                {
                    //if not found, creates a new order by calling the order create method and returning the IActionResult as its own result.
                    Order newOrder = new Order();
                    return await this.Create(newOrder);
                }
            }

            var order = await _context.Order
                .Include(o => o.PaymentType)
                .Include(o => o.User)
                .FirstOrDefaultAsync(m => m.OrderId == id);

            if (order == null)
            {
                return NotFound();
            }

            var orderProducts = await _context.OrderProduct
                .Where(o => o.OrderId == id).ToListAsync();

            var OrdertTotal = 0.0;

            //get the Product for each orderProduct.
            foreach (var item in orderProducts)
            {
                item.Product = await _context.Product.FirstOrDefaultAsync(p => p.ProductId == item.ProductId);
                OrdertTotal += item.Product.Price;
            }

            //Add the list of orderProducts to the order.
            order.OrderProducts = orderProducts;

            //Adding the price of each product together.
            order.OrderTotal = OrdertTotal;

            return View(order);
        }

        // DELETE method for clearing the customers active shopping cart. This will trigger a DELETE from the ORDERPRODUCT table for all entities that have the orderId of the current order
        public async Task<IActionResult> ClearCartConfirmed(int id)
        {
            // Make a list of order products with orderId = parameter id (current order / shopping cart OrderId)
            var orderProductsToDelete = await _context.OrderProduct.Where(op => op.OrderId == id).ToListAsync();

            // For each item in the list, mark the entity state as DELETED
            foreach(var item in orderProductsToDelete)
            {

                _context.OrderProduct.Remove(item);
            }

            // Execute the delete from OrderProduct table

            await _context.SaveChangesAsync();

            // Redirect the user to the home page

            return RedirectToAction("Index", "Home");
        }

        private bool OrderExists(int id)
        {
            return _context.Order.Any(e => e.OrderId == id);
        }

    }
}
