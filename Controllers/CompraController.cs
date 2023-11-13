using Hotel.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Controllers
{
    
    public class CompraController
    {
        HotelContext _context;
        public CompraController(HotelContext context)
        {
            _context = context;
        }
        public async Task<List<Compra>> GetAllObject()
        {
           return await _context.Compras.ToListAsync();

        }
        public async void AddObject(Compra obj)
        {
            _context.Compras.Add(obj);
            _context.SaveChangesAsync();
        }
        public async void UpdateObject(Compra obj)
        {
            _context.Compras.Update(obj);
            _context.SaveChangesAsync();
        }
        public async void DeleteObject(int id)
        {
            var obj = await FindObject(id);
            if (obj != null)
            {
                _context.Compras.Remove(obj);
                _context.SaveChangesAsync();
            }
        }
        public async Task<Compra> FindObject(int id)
        {
            return await _context.Compras.FindAsync(id);
            
        }
    }
}
