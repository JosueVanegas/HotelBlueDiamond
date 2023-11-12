using Hotel.Models;
using Microsoft.Data.SqlClient;
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
        public void AddObject(Cliente objects)
        {
            _context.Clientes.Add(objects);
            _context.SaveChanges();
        }
        public List<Cliente> GetAllObjects()
        {
            return _context.Clientes.ToList();
        }
        public void UpdateObject(Cliente objects)
        {
            _context.Clientes.Update(objects);
            _context.SaveChanges();
        }
        public void DeleteObject(int id)
        {
            var objects = _context.Clientes.Find(id);
            if (objects != null)
            {
                _context.Clientes.Remove(objects);
                _context.SaveChanges();
            }
        }
        public Cliente GetObjectById(int id)
        {
            return _context.Clientes.Find(id);
        }
        /*
         * public void ExecuteStoredProcedure(string storedProcedure, params SqlParameter[] parameters)
        {
            using var context = new YourDbContext();
            context.Database.ExecuteSqlRaw($"EXECUTE {storedProcedure}", parameters);
        }
         */

    }
}
