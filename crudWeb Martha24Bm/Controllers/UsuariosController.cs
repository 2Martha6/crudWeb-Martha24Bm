using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using crudWeb_Martha24Bm.Models;

namespace crudWeb_Martha24Bm.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly ProgramacionContext _context;

        public UsuariosController(ProgramacionContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index() {  
      
            var DataInfo = await _context.Usuarios.ToListAsync();
            return View(DataInfo);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Usuario usuarios)
        {
            try
            {
                
                _context.Usuarios.Add(usuarios);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                throw;
            }
        }
        [HttpGet]
        public IActionResult Edit(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var informacion = _context.Usuarios.Find(Id);
            if (informacion == null)
            {
                return NotFound();
            }
            return View(informacion);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Usuario usuario)
        {
           
            
            if (ModelState.IsValid != null)
            {
                _context.Usuarios.Update(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }
        [HttpGet]
        public IActionResult Details(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }
            var curriculums = _context.Usuarios.Find(Id);
            if (curriculums == null)
            {
                return NotFound();
            }
            return View(curriculums);
        }
        [HttpGet]
        public IActionResult Delete(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }
            var informacion = _context.Usuarios.Find(Id);
            if (informacion == null)
            {
                return NotFound();
            }
            return View(informacion);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BorrarCurriculum(int? Id)
        {
            var usuario = await _context.Usuarios.FindAsync(Id);
            if (usuario == null)
            {
                return View();
            }
            _context.Usuarios.Remove(usuario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
