using Hotel.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Hotel.Controller
{
    public class ClienteController
    {
        private readonly HotelContext _context;

        public ClienteController(HotelContext context)
        {
            _context = context;
        }
        public async void AddObject(Cliente objects)
        {
            _context.Clientes.AddAsync(objects);
            _context.SaveChangesAsync();
        }
        public async Task<List<Cliente>> GetAllObjects()
        {
            return await _context.Clientes.ToListAsync();
        }
        public async void UpdateObject(Cliente objects)
        {
            _context.Clientes.Update(objects);
            _context.SaveChangesAsync();
        }
        public async void DeleteObject(int id)
        {
            var objects = await _context.Clientes.FindAsync(id);
            if (objects != null)
            {
                _context.Clientes.Remove(objects);
                _context.SaveChangesAsync();
            }
        }
        public async Task<Cliente> GetObjectById(int id)
        {
            return await _context.Clientes.FindAsync(id);
        }
    }
}
