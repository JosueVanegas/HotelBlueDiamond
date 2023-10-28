using Hotel_Dorado_DesktopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Dorado_DesktopApp.Controllers
{
    public class CategoriaHabitacionesController
    {
        private readonly HotelDoradoContext _context;

        public CategoriaHabitacionesController(HotelDoradoContext context)
        {
            _context = context;
        }

        public void AddObject(CategoriaHabitacion objects)
        {
            _context.CategoriaHabitacions.Add(objects);
            _context.SaveChanges();
        }
        public List<CategoriaHabitacion> GetAllObjects()
        {
            return _context.CategoriaHabitacions.ToList();
        }
        public void UpdateObject(CategoriaHabitacion objects)
        {
            _context.CategoriaHabitacions.Update(objects);
            _context.SaveChanges();
        }
        public void DeleteObject(int id)
        {
            var objects = _context.CategoriaHabitacions.Find(id);
            if (objects != null)
            {
                _context.CategoriaHabitacions.Remove(objects);
                _context.SaveChanges();
            }
        }
        public CategoriaHabitacion GetObjectById(int id)
        {
            return _context.CategoriaHabitacions.Find(id);
        }
    }
}
