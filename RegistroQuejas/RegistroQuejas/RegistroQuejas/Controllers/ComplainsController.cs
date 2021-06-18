using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RegistroQuejas.Data;
using RegistroQuejas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroQuejas.Controllers
{
    public class ComplainsController : Controller
    {
        private readonly ApplicationDbContext db;
        public ComplainsController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public async Task<IActionResult> Index(string search)
        {
            if (search==null)
            {
                return View(await db.Complains.ToListAsync());
            }
            return View(await db.Complains
                .Where(c => c.QuejaNombre.Contains(search))
                .ToListAsync());
        }
        //detalles de la tabla
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var complain = await db.Complains.FirstOrDefaultAsync(c => c.QuejaId == id);
            if (complain == null)
            {
                return NotFound();
            }
            return View(complain);
        }
        //creacion vista
        public IActionResult Create()
        {
            return View();
        }

        //nuevo
        [HttpPost]//metodo atraves de post
        [ValidateAntiForgeryToken]//complementa la validacion en el metodo si es correcto y no venga codigo malicioso
        public async Task<IActionResult> Create(Complain complain)
        {
            if (ModelState.IsValid)
            {
                db.Add(complain);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(complain);
        }

        //editar
        public async Task<IActionResult> Edit(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            var complain = await db.Complains.FindAsync(id);
            if (complain == null)
            {
                return NotFound();
            }
            return View(complain);
        }

        //guardar modificaciones en la dbf
        [HttpPost]//metodo atraves de post
        [ValidateAntiForgeryToken]//complementa la validacion en el metodo si es correcto y no venga codigo malicioso
        public async Task<IActionResult> Edit(int id, Complain complain)
        {
            if (id != complain.QuejaId)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    db.Update(complain);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                }

                return RedirectToAction(nameof(Index));
            }
            return View(complain);
        }
        //fin editar
        //borrar
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var complain = await db.Complains.FirstOrDefaultAsync(c => c.QuejaId == id);
            //buscar en la tabla de departamentos y quedara en depart
            if (complain == null)
            {
                return NotFound();
            }

            return View(complain);
        }
        //inicio borrar
        [HttpPost, ActionName("Delete")]//metodo atraves de post, el metodo hace el llamado
        [ValidateAntiForgeryToken]//complementa la validacion en el metodo si es correcto y no venga codigo malicioso
        public async Task<IActionResult> Delete(int id)
        {
            var complain = await db.Complains.FindAsync(id);
            db.Complains.Remove(complain);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        //fin borrar
    }
}
