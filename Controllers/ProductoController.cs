using Hotel.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Controllers
{
    public class ProductoController
    {
        HotelContext _context;
        public ProductoController(HotelContext context)
        {
            this._context = context;
        }
        public void AddObject(Producto producto)
        {
            _context.Productos.AddAsync(producto);
            _context.SaveChangesAsync(); 
        }
        public async Task<List<Producto>> GetAllObject()
        {
            return await _context.Productos.Include(p=>p.CategoriaProducto).Include(p=>p.Proveedor).Where(p=>p.Activo==true).ToListAsync();
        }
        public void UpdateObject(Producto producto)
        {
            _context.Productos.Update(producto);
            _context.SaveChangesAsync();
        }
        public async void DeleteObject(int id)
        {
            var obj = await GetObject(id);
            if (obj != null)
            {
                obj.Activo = false;
                _context.SaveChangesAsync();
            }
        }
        public async Task<Producto> GetObject(int id)
        {
            return await _context.Productos.FindAsync(id);
        }
    }
}
