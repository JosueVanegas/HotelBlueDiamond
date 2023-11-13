using Hotel.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Controllers
{
    public class EmpleadosController
    {
        HotelContext _context;   
        public EmpleadosController(HotelContext context)
        {
            this._context = context;
        }
        public async Task<List<Empleado>> GetAllObjects()
        {
            return await _context.Empleados.Include(e=>e.Cargo).Where(e=>e.Activo == true).ToListAsync();
        }
        public async void AddObject(Empleado obj)
        {
            _context.Empleados.Add(obj);
            _context.SaveChangesAsync();
        }
        public async void DeleteObject(int id)
        {
            var obj = await _context.Empleados.FindAsync(id);
            if (obj != null)
            {
                obj.Activo = false;
                _context.SaveChangesAsync();
            }
        }
        public async void UpdateObject(Empleado obj)
        {
            _context.Update(obj);
            _context.SaveChangesAsync();
        }
        public async Task<Empleado> GetObjectById(int id)
        {
            return await _context.Empleados.Include(e => e.Cargo).FirstOrDefaultAsync(e=>e.EmpleadoId == id);
        }
    }
}
