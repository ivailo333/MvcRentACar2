#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcRentACar2.Data;
using MvcRentACar2.Models;

namespace MvcRentACar2.Controllers
{
    public class CarRentalTimesController : Controller
    {
        private readonly MvcRentACar2Context _context;

        public CarRentalTimesController(MvcRentACar2Context context)
        {
            _context = context;
        }

        // GET: CarRentalTimes
        [Authorize]
        [Route("CarRentalTimes")]
        public async Task<IActionResult> Index(string searchString)
        {
            var carrentaltimes = from crt in _context.CarRentalTime
                       select crt;
            if (!String.IsNullOrEmpty(searchString))
            {
                carrentaltimes = carrentaltimes.Where(s => s.ClientId.ToString().Contains(searchString));
            }
            return View(await carrentaltimes.ToListAsync());
        }

        // GET: CarRentalTimes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carRentalTime = await _context.CarRentalTime
                .FirstOrDefaultAsync(m => m.Id == id);
            if (carRentalTime == null)
            {
                return NotFound();
            }

            return View(carRentalTime);
        }

        // GET: CarRentalTimes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CarRentalTimes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ClientId,EmployeeId,DateTime1,Duration")] CarRentalTime carRentalTime)
        {
            if (ModelState.IsValid)
            {
                _context.Add(carRentalTime);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(carRentalTime);
        }

        // GET: CarRentalTimes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carRentalTime = await _context.CarRentalTime.FindAsync(id);
            if (carRentalTime == null)
            {
                return NotFound();
            }
            return View(carRentalTime);
        }

        // POST: CarRentalTimes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ClientId,EmployeeId,DateTime1,Duration")] CarRentalTime carRentalTime)
        {
            if (id != carRentalTime.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(carRentalTime);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarRentalTimeExists(carRentalTime.Id))
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
            return View(carRentalTime);
        }

        // GET: CarRentalTimes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carRentalTime = await _context.CarRentalTime
                .FirstOrDefaultAsync(m => m.Id == id);
            if (carRentalTime == null)
            {
                return NotFound();
            }

            return View(carRentalTime);
        }

        // POST: CarRentalTimes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var carRentalTime = await _context.CarRentalTime.FindAsync(id);
            _context.CarRentalTime.Remove(carRentalTime);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarRentalTimeExists(int id)
        {
            return _context.CarRentalTime.Any(e => e.Id == id);
        }
    }
}
