using Hotel_Dorado_DesktopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Dorado_DesktopApp.Controllers
{
    public class HabitacionesController
    {
        private readonly HotelDoradoContext _context;

        public HabitacionesController(HotelDoradoContext context)
        {
            _context = context;
        }

        public void AddObject(Habitacion objects)
        {
            _context.Habitacions.Add(objects);
            _context.SaveChanges();
        }
        public List<Habitacion> GetAllObjects()
        {
            return _context.Habitacions.ToList();
        }
        public void UpdateObject(Habitacion objects)
        {
            _context.Habitacions.Update(objects);
            _context.SaveChanges();
        }
        public void DeleteObject(int id)
        {
            var objects = _context.Habitacions.Find(id);
            if (objects != null)
            {
                _context.Habitacions.Remove(objects);
                _context.SaveChanges();
            }
        }
        public Habitacion GetObjectById(int id)
        {
            return _context.Habitacions.Find(id);
        }
    }
}
