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
        public async Task<int> AddObject(Compra obj)
        {
            _context.Compras.Add(obj);
             await _context.SaveChangesAsync();
            int idG = obj.CompraId;

            return idG;
        }
        public async void UpdateObject(Compra obj)
        {
            _context.Compras.Update(obj);
            await _context.SaveChangesAsync();
        }
        public async void DeleteObject(int id)
        {
            var obj = await FindObject(id);
            if (obj != null)
            {
                _context.Compras.Remove(obj);
               await _context.SaveChangesAsync();
            }
        }
        public async Task<Compra> FindObject(int id)
        {
            return await _context.Compras.FindAsync(id);
            
        }
        public void AddDetalles(DetalleCompra obj)
        {
            _context.DetalleCompras.Add(obj);
            _context.SaveChanges();
        }
        public void ChageStockProductLess(int productID,int newStock)
        {
           var product = _context.Productos.Where(p=>p.ProductoId == productID).FirstOrDefault();
            if(product != null)
            {
                product.Stock = newStock; 
                _context.SaveChanges();
            }
        }
    }
}
