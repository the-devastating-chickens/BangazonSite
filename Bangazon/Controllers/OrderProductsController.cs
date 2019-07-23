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

namespace Bangazon.Controllers
{
    public class OrderProductsController : Controller
    {
        private readonly ApplicationDbContext _context;

        private readonly UserManager<ApplicationUser> _userManager;


        public OrderProductsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        // GET: OrderProducts
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.OrderProduct.Include(o => o.Order).Include(o => o.Product);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: OrderProducts/Details/5
        [ActionName("Details")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderProduct = await _context.OrderProduct
                .Include(o => o.Order)
                .Include(o => o.Product)
                .FirstOrDefaultAsync(m => m.OrderProductId == id);
            if (orderProduct == null)
            {
                return NotFound();
            }

            return View(orderProduct);
        }

        // GET: OrderProducts/Create
        public IActionResult Create()
        {
            ViewData["OrderId"] = new SelectList(_context.Order, "OrderId", "UserId");
            ViewData["ProductId"] = new SelectList(_context.Product, "ProductId", "Description");
            return View();
        }

        // POST: OrderProducts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int? id, [Bind("OrderProductId,OrderId,ProductId")] OrderProduct orderProduct)
        {

            var currentUser = await GetCurrentUserAsync();

            if (ModelState.IsValid)
            {
                int productId = Convert.ToInt32(id);
                orderProduct.ProductId = productId;
                //get a list of all orders from db.
                List<Order> orders = await _context.Order.ToListAsync();
                //find order that matches the user Id and has no date completed.
                Order order = orders.Find(o => o.UserId == currentUser.Id && o.PaymentTypeId == null);
                //if found, add orderID to orderProduct.
                if (order != null)
                {
                    //set orderProduct.OrderId to the Order's id.
                    orderProduct.OrderId = order.OrderId;
                    //add to context and save changes.
                    _context.Add(orderProduct);
                    await _context.SaveChangesAsync();
                    //Redirect to order details page of the current order.
                    return RedirectToAction("Details", "Orders", new { id = order.OrderId });
                    //if no order is found, creates one.
                }
                else
                {
                    Order newOrder = new Order
                    {
                        DateCreated = DateTime.Now,
                        UserId = currentUser.Id,
                        User = currentUser,
                    };
                    _context.Add(newOrder);
                    //set orderProduct.OrderId to the id of the new order.
                    orderProduct.OrderId = newOrder.OrderId;
                    //add to context and save changes.
                    _context.Add(orderProduct);
                    await _context.SaveChangesAsync();
                    //find the newly-created order.
                    Order currentOrder = await _context.Order
                        .FirstOrDefaultAsync(m => m.PaymentTypeId == null && m.UserId == currentUser.Id);
                    //go to Order details of the order.
                    return RedirectToAction("Details", "Orders", new { id = currentOrder.OrderId });
                }
            } else
            {
                return StatusCode(422);
            }
        }

        // GET: OrderProducts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderProduct = await _context.OrderProduct.FindAsync(id);
            if (orderProduct == null)
            {
                return NotFound();
            }
            ViewData["OrderId"] = new SelectList(_context.Order, "OrderId", "UserId", orderProduct.OrderId);
            ViewData["ProductId"] = new SelectList(_context.Product, "ProductId", "Description", orderProduct.ProductId);
            return View(orderProduct);
        }

        // POST: OrderProducts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderProductId,OrderId,ProductId")] OrderProduct orderProduct)
        {
            if (id != orderProduct.OrderProductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orderProduct);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderProductExists(orderProduct.OrderProductId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["OrderId"] = new SelectList(_context.Order, "OrderId", "UserId", orderProduct.OrderId);
            ViewData["ProductId"] = new SelectList(_context.Product, "ProductId", "Description", orderProduct.ProductId);
            return View(orderProduct);
        }

        // GET: OrderProducts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderProduct = await _context.OrderProduct
                .Include(o => o.Order)
                .Include(o => o.Product)
                .FirstOrDefaultAsync(m => m.OrderProductId == id);
            if (orderProduct == null)
            {
                return NotFound();
            }

            return View(orderProduct);
        }

        // POST: OrderProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var orderProduct = await _context.OrderProduct.FindAsync(id);
            _context.OrderProduct.Remove(orderProduct);
            await _context.SaveChangesAsync();
            return RedirectToAction("Details", "Orders", new { id = orderProduct.OrderId});
        }

        private bool OrderProductExists(int id)
        {
            return _context.OrderProduct.Any(e => e.OrderProductId == id);
        }
    }
}
