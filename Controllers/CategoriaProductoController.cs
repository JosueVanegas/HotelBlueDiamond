using Hotel_Dorado_DesktopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Dorado_DesktopApp.Controllers
{
    public class CategoriaProductoController
    {
        HotelDoradoContext _context;
        public CategoriaProductoController(HotelDoradoContext context)
        {
            this._context = context;
        }
        public void AddObject(CategoriaProducto categoria)
        {
            _context.CategoriaProductos.Add(categoria);
            _context.SaveChanges();
        }
        public List<CategoriaProducto> GetAllObject()
        {
            return _context.CategoriaProductos.ToList();
        }
        public void UpdateObject(CategoriaProducto categoria)
        {
            _context.CategoriaProductos.Update(categoria);
            _context.SaveChanges();
        }
        public void DeleteObject(int id)
        {
            var obj = GetObject(id);
            if (obj != null)
            {
                _context.Remove(obj);
                _context.SaveChanges();
            }
        }
        public CategoriaProducto GetObject(int id)
        {
            return _context.CategoriaProductos.Find(id);
        }
    }
}
