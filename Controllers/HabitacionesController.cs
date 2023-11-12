using Hotel.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Controllers
{
    public class HabitacionesController
    {
        private readonly HotelContext _context;

        public HabitacionesController(HotelContext context)
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
            return _context.Habitacions.Include(h=>h.CategoriaHabitacion).Include(h=>h.Piso).Include(h=>h.Estado).ToList();
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
        public List<EstadoHabitacion> GetEstadoHabitacions()
        {
            return _context.EstadoHabitacions.ToList();
        }
        public List<CategoriaHabitacion> GetCategoriaHabitacions()
        {
            return _context.CategoriaHabitacions.ToList();
        }
        public List<Piso> GetPisoHabitacions()
        {
            return _context.Pisos.ToList();
        }
        public Habitacion GetObjectById(int id)
        {
            return _context.Habitacions.Find(id);
        }
    }
}
