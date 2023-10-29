using Hotel_Dorado_DesktopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Dorado_DesktopApp.Controllers
{
    public class EmpleadosController
    {
        HotelDoradoContext _context;   
        public EmpleadosController(HotelDoradoContext context)
        {
            this._context = context;
        }
        public List<Empleado> GetAllObjects()
        {
            return _context.Empleados.ToList();
        }
        public void AddObject(Empleado obj)
        {
            _context.Empleados.Add(obj);
            _context.SaveChanges();
        }
        public void DeleteObject(int id)
        {
            var obj = _context.Empleados.Find(id);
            if(obj != null)
            {
                _context.Empleados.Remove(obj);
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
            return _context.Empleados.Find(id);
        }
    }
}
