using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Amazon.DynamoDBv2;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Office.CustomUI;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrashCollector.Data;
using TrashCollector.Models;

namespace TrashCollector.Controllers
{
    [Authorize(Roles = "Employee")]
    public class EmployeesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Employees
        public ActionResult Index(string dayOfWeek)
        {
           
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var employee = _context.Employee.Where(e => e.IdentityUserId == userId).SingleOrDefault();
            if (employee == null)
            {
               return RedirectToAction("Create");
            }
            var customers = _context.Customer.Where(c => c.ZipCode == employee.ZipCode).ToList();
            var filiteredCustomers = customers.Where(c => c.WeeklyPickUpDay == dayOfWeek).ToList();
            return View(filiteredCustomers); 
          
        }

        // GET: Employees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = _context.Employee
            .Include(e => e.IdentityUser)
            .FirstOrDefault(m => m.Id == id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Id,Name,ZipCode,WeeklyPickUpDay,PickUpTime,StartDayOfService,EndDayOfService,ExtraOneTimePickUp,CompletedPickUp,IdentityUserId")] Employee employee)
        {
          
            
                if (ModelState.IsValid)
                {
                    var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                     employee.IdentityUserId = userId;
                    _context.Add(employee);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", employee.IdentityUserId);
                return View(employee);
        }
        
        // GET: Employees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee =  _context.Employee.Find(id);
            if (employee == null)
            {
                return NotFound();
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", employee.IdentityUserId);
            return View(employee);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [Bind("Id,Name,ZipCode,WeeklyPickUpDay,CompletedPickUp,Balance")] Employee employee)
        {
            if (id != employee.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employee);
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(employee.Id))
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
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", employee.IdentityUserId);
            return View(employee);
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee =  _context.Employee
                .Include(e => e.IdentityUser)
                .FirstOrDefault(m => m.Id == id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                var employee = _context.Employee.Find(id);
                _context.Employee.Remove(employee);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch 
            {

                return View();
            }
           
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employee.Any(e => e.Id == id);
        }

        // create a button for each pickup in the index view that triggers an action "PickupComplete"

        // write an action (method) that sets our bool on the customer equal to "true" 
        public ActionResult PickUpComplete(Customer customer)
        {
            if (customer.ExtraOneTimePickUpButton == true)
            {
                customer = _context.Customer.Find(customer);
                _context.Customer.Remove(customer);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
               
            }
            return View();
        }
        
        // Now, when you filter by customers with pickups, if their complete = TRUE, don't list
    }

}
