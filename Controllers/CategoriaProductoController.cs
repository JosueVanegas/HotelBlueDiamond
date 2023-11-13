using Hotel.Models;
using Microsoft.EntityFrameworkCore;
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
        public async void AddObject(CategoriaProducto categoria)
        {
            _context.CategoriaProductos.AddAsync(categoria);
            _context.SaveChangesAsync();
        }
        public async Task<List<CategoriaProducto>> GetAllObject()
        {
            return await _context.CategoriaProductos.ToListAsync();
        }
        public async void UpdateObject(CategoriaProducto categoria)
        {
            _context.CategoriaProductos.Update(categoria);
            _context.SaveChangesAsync();
        }
        public async void DeleteObject(int id)
        {
            var obj = await GetObject(id);
            if (obj != null)
            {
                _context.CategoriaProductos.Remove(obj);
                _context.SaveChangesAsync();
            }
        }
        public async Task<CategoriaProducto> GetObject(int id)
        {
            return await _context.CategoriaProductos.FindAsync(id);
        }
    }
}
