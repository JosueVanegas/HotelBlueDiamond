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
        public List<Empleado> GetAllObjects()
        {
            return _context.Empleados.Include(e=>e.Cargo).Where(e=>e.Activo == true).ToList();
        }
        public void AddObject(Empleado obj)
        {
            _context.Empleados.Add(obj);
            _context.SaveChanges();
        }
        public void DeleteObject(int id)
        {
            var obj = _context.Empleados.Find(id);
            if (obj != null)
            {
                obj.Activo = false;
                _context.SaveChanges();
            }
        }
        public void UpdateObject(Empleado obj)
        {
            _context.Update(obj);
            _context.SaveChanges();
        }
        public Empleado GetObjectById(int id)
        {
            return _context.Empleados.Include(e => e.Cargo).FirstOrDefault(e=>e.EmpleadoId == id);
        }
    }
}
