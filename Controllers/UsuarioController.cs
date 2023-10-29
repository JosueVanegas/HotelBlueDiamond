using Hotel_Dorado_DesktopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Dorado_DesktopApp.Controllers
{
    public class UsuarioController
    {
        HotelDoradoContext _context;

        public UsuarioController(HotelDoradoContext context)
        {
            this._context = context;
        }
        public void AddObject(Usuario obj)
        {
            _context.Usuarios.Add(obj);
            _context.SaveChanges();
        }
        public List<Usuario> GetAllObject()
        {
            return _context.Usuarios.ToList();
        }
        public void UpdateObject(Usuario obj)
        {
            _context.Usuarios.Update(obj);
            _context.SaveChanges();
        }
        public void DeleteObject(int id)
        {
            var obj = _context.Usuarios.Find(id);
            if (obj != null)
            {
                _context.Usuarios.Remove(obj);
                _context.SaveChanges();
            }
        }
        public Usuario GetObjectById(int id)
        {
            return _context.Usuarios.Find(id);
        }
    }
}
