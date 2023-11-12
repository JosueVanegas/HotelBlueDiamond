using Hotel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Controllers
{
    public class CategoriaProductoController
    {
        HotelContext _context;
        public CategoriaProductoController(HotelContext context)
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
                _context.CategoriaProductos.Remove(obj);
                _context.SaveChanges();
            }
        }
        public CategoriaProducto GetObject(int id)
        {
            return _context.CategoriaProductos.Find(id);
        }
    }
}
