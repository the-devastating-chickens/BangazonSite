﻿using System;
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
            var applicationDbContext = _context.Order.Include(o => o.PaymentType).Include(o => o.User).Where(o => o.UserId == currentUser.Id && o.PaymentType != null);
            return View(await applicationDbContext.ToListAsync());
        }

        //Modified by Anne Vick. Now gets a list of orderProducts associated with the order's orderId.
        // GET: Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
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
        public async Task<IActionResult> Create([Bind("DateCreated, UserId, User")] Order order)
        {
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);

            if (ModelState.IsValid)
            {

                order.DateCreated = DateTime.Now;
                order.UserId = currentUser.Id;
                order.User = currentUser;

                _context.Add(order);
                //add to context and save changes.
                _context.Add(order);
                await _context.SaveChangesAsync();
                return View(order);
            }
            else
            {
                return StatusCode(422);

            }

        }

        // POST: Orders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("OrderId,DateCreated,DateCompleted,UserId,PaymentTypeId")] Order order)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(order);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["PaymentTypeId"] = new SelectList(_context.PaymentType, "PaymentTypeId", "AccountNumber", order.PaymentTypeId);
        //    ViewData["UserId"] = new SelectList(_context.ApplicationUsers, "Id", "Id", order.UserId);
        //    return View(order);
        //}

        // GET: Orders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            var currentUser = await GetCurrentUserAsync();

            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Order.FindAsync(id);
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
        public async Task<IActionResult> Edit(int id, [Bind("OrderId,DateCreated,DateCompleted,UserId,PaymentTypeId")] Order order)
        {
            if (id != order.OrderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
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
                return RedirectToAction(nameof(Index));
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

        private bool OrderExists(int id)
        {
            return _context.Order.Any(e => e.OrderId == id);
        }
    }
}
