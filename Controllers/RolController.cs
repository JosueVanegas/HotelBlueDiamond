using Hotel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Controllers
{
    public class RolController
    {
        HotelContext _context;

        public RolController(HotelContext context)
        {
            this._context = context;
        }
        public void AddObject(Rol obj)
        {
            _context.Rols.Add(obj);
            _context.SaveChanges();
        }
        public List<Rol> GetAllObject()
        {
            return _context.Rols.ToList();
        }
        public void UpdateObject(Rol obj)
        {
            _context.Rols.Update(obj);
            _context.SaveChanges();
        }
        public void DeleteObject(int id)
        {
            var obj = _context.Rols.Find(id);
            if (obj != null)
            {
                _context.Rols.Remove(obj);
                _context.SaveChanges();
            }
        }
        public Rol GetObjectById(int id)
        {
            return _context.Rols.Find(id);
        }
    }
}
