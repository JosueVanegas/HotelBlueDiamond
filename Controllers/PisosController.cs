using Hotel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Controllers
{
    public class PisosController
    {
        private readonly HotelContext _context;

        public PisosController(HotelContext context)
        {
            _context = context;
        }
        public void AddObject(Piso objects)
        {
            _context.Pisos.Add(objects);
            _context.SaveChanges();
        }
        public List<Piso> GetAllObjects()
        {
            return _context.Pisos.ToList();
        }
        public void UpdateObject(Piso objects)
        {
            _context.Pisos.Update(objects);
            _context.SaveChanges();
        }
        public void DeleteObject(int id)
        {
            var objects = _context.Pisos.Find(id);
            if (objects != null)
            {
                _context.Pisos.Remove(objects);
                _context.SaveChanges();
            }
        }
        public Piso GetObjectById(int id)
        {
            return _context.Pisos.Find(id);
        }
    }
}
