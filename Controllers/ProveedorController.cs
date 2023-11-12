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

        public async Task AddObjectAsync(Proveedor obj)
        {
            _context.Proveedors.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Proveedor>> GetAllObjectAsync()
        {
            return await _context.Proveedors.ToListAsync();
        }

        public async Task UpdateObjectAsync(Proveedor obj)
        {
            _context.Proveedors.Update(obj);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteObjectAsync(int id)
        {
            var obj = await GetObjectAsync(id);
            if (obj != null)
            {
                _context.Proveedors.Remove(obj);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Proveedor> GetObjectAsync(int id)
        {
            return await _context.Proveedors.FindAsync(id);
        }
    }
}
