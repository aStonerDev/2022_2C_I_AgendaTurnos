using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _2022_2C_I_AgendaTurnos.Data;
using _2022_2C_I_AgendaTurnos.Models;

namespace _2022_2C_I_AgendaTurnos.Controllers
{
    public class PrestacionsController : Controller
    {
        private readonly AgendaContext _context;

        public PrestacionsController(AgendaContext context)
        {
            _context = context;
        }

        // GET: Prestacions
        public async Task<IActionResult> Index()
        {
              return View(await _context.Prestaciones.ToListAsync());
        }

        // GET: Prestacions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Prestaciones == null)
            {
                return NotFound();
            }

            var prestacion = await _context.Prestaciones
                .FirstOrDefaultAsync(m => m.IdPrestacion == id);
            if (prestacion == null)
            {
                return NotFound();
            }

            return View(prestacion);
        }

        // GET: Prestacions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Prestacions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdPrestacion,Nombre,Descripcion,Duracion,Precio")] Prestacion prestacion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(prestacion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(prestacion);
        }

        // GET: Prestacions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Prestaciones == null)
            {
                return NotFound();
            }

            var prestacion = await _context.Prestaciones.FindAsync(id);
            if (prestacion == null)
            {
                return NotFound();
            }
            return View(prestacion);
        }

        // POST: Prestacions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdPrestacion,Nombre,Descripcion,Duracion,Precio")] Prestacion prestacion)
        {
            if (id != prestacion.IdPrestacion)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(prestacion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PrestacionExists(prestacion.IdPrestacion))
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
            return View(prestacion);
        }

        // GET: Prestacions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Prestaciones == null)
            {
                return NotFound();
            }

            var prestacion = await _context.Prestaciones
                .FirstOrDefaultAsync(m => m.IdPrestacion == id);
            if (prestacion == null)
            {
                return NotFound();
            }

            return View(prestacion);
        }

        // POST: Prestacions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Prestaciones == null)
            {
                return Problem("Entity set 'AgendaContext.Prestaciones'  is null.");
            }
            var prestacion = await _context.Prestaciones.FindAsync(id);
            if (prestacion != null)
            {
                _context.Prestaciones.Remove(prestacion);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PrestacionExists(int id)
        {
          return _context.Prestaciones.Any(e => e.IdPrestacion == id);
        }
    }
}
