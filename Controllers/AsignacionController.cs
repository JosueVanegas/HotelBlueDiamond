using Hotel_Dorado_DesktopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Dorado_DesktopApp.Controllers
{
    public class AsignacionController
    {
        HotelDoradoContext _context;
        public AsignacionController (HotelDoradoContext context)
        {
            this._context = context;
        }
        public void AddObject(Asignacion obj)
        {
            _context.Asignacions.Add(obj);
            _context.SaveChanges();
        }
        public List<Asignacion> GetAllObjects()
        {
            return _context.Asignacions.ToList();
        }
        public void UpdateObject(Asignacion obj)
        {
            _context.Asignacions.Update(obj);
            _context.SaveChanges();
        }
        public void DeleteObject(int id)
        {
            var obj = _context.Asignacions.Find(id);
            if (obj != null)
            {
                _context.Asignacions.Remove(obj);
                _context.SaveChanges();
            }
        }
        public Asignacion GetObjectById(int id)
        {
            return _context.Asignacions.Find(id);
        }
    }
}
