using Hotel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Controllers
{
    public class CargosController
    {
        HotelContext _context;

        public CargosController(HotelContext context)
        {
            this._context = context;
        }
        public void AddObject(Cargo obj)
        {
            _context.Cargos.Add(obj);
            _context.SaveChanges();
        }
        public List<Cargo> GetAllObject()
        {
            return _context.Cargos.ToList();
        }
        public void UpdateObject(Cargo obj)
        {
            _context.Cargos.Update(obj);
            _context.SaveChanges();
        }
        public void DeleteObject(int id)
        {
            var obj = _context.Cargos.Find(id);
            if(obj != null)
            {
                _context.Cargos.Remove(obj);
                _context.SaveChanges();
            }
        }
        public Cargo GetObjectById(int id)
        {
            return _context.Cargos.Find(id);
        }
    }
}
