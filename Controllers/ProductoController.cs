using Hotel_Dorado_DesktopApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Dorado_DesktopApp.Controllers
{
    public class ProductoController
    {
        HotelDoradoContext _context;
        public ProductoController(HotelDoradoContext context)
        {
            this._context = context;
        }
        public void AddObject(Producto producto)
        {
            _context.Productos.Add(producto);
            _context.SaveChanges(); 
        }
        public List<Producto> GetAllObject()
        {
            return _context.Productos.Include(p=>p.CategoriaProducto).ToList();
        }
        public void UpdateObject(Producto producto)
        {
            _context.Productos.Update(producto);
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
        public Producto GetObject(int id)
        {
            return _context.Productos.Find(id);
        }
    }
}
