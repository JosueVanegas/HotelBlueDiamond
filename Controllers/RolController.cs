using Hotel.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Controllers
{
    public class RolController
    {
        HotelContext _context;

        public RolController(HotelContext context)
        {
            this._context = context;
        }
        public async void AddObject(Rol obj)
        {
            _context.Rols.Add(obj);
            _context.SaveChangesAsync();
        }
        public async Task<List<Rol>> GetAllObject()
        {
            return await _context.Rols.ToListAsync();
        }
        public async void UpdateObject(Rol obj)
        {
            _context.Rols.Update(obj);
            _context.SaveChangesAsync();
        }
        public async void DeleteObject(int id)
        {
            var obj = await _context.Rols.FindAsync(id);
            if (obj != null)
            {
                _context.Rols.Remove(obj);
                _context.SaveChangesAsync();
            }
        }
        public async Task<Rol> GetObjectById(int id)
        {
            return await _context.Rols.FindAsync(id);
        }
    }
}
