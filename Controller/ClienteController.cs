using Hotel_Dorado_DesktopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Hotel_Dorado_DesktopApp.Controller
{
    public class ClienteController
    {
        private readonly HotelDoradoContext _context;

        public ClienteController(HotelDoradoContext context)
        {
            _context = context;
        }
        // Create
        public void AddObject(Cliente objects)
        {
            _context.Clientes.Add(objects);
            _context.SaveChanges();
        }

        // Read (single guest by ID)
        public Cliente GetObjectById(int id)
        {
            return _context.Clientes.Find(id);
        }

        // Read (all guests)
        public List<Cliente> GetAllObjects()
        {
            return _context.Clientes.ToList();
        }

        // Update
        public void UpdateObject(Cliente objects)
        {
            _context.Clientes.Update(objects);
            _context.SaveChanges();
        }

        // Delete
        public void DeleteObject(int id)
        {
            var objects = _context.Clientes.Find(id);
            if (objects != null)
            {
                _context.Clientes.Remove(objects);
                _context.SaveChanges();
            }
        }
    }
}
