using Hotel.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Controllers
{
    public class ProveedorController
    {
        private readonly HotelContext _context;

        public ProveedorController(HotelContext context)
        {
            this._context = context;
        }

        public async void AddObjectAsync(Proveedor obj)
        {
            _context.Proveedors.AddAsync(obj);
             _context.SaveChangesAsync();
        }

        public async Task<List<Proveedor>> GetAllObjectAsync()
        {
            return await _context.Proveedors.ToListAsync();
        }

        public async void UpdateObjectAsync(Proveedor obj)
        {
            _context.Proveedors.Update(obj);
             _context.SaveChangesAsync();
        }

        public async void DeleteObjectAsync(int id)
        {
            var obj = await GetObjectAsync(id);
            if (obj != null)
            {
                _context.Proveedors.Remove(obj);
                 _context.SaveChangesAsync();
            }
        }

        public async Task<Proveedor> GetObjectAsync(int id)
        {
            return await _context.Proveedors.FindAsync(id);
        }
    }
}
