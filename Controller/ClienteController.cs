using Hotel_Dorado_DesktopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void AddGuest(Cliente guest)
        {
            _context.Clientes.Add(guest);
            _context.SaveChanges();
        }

        // Read (single guest by ID)
        public Cliente GetGuestById(int id)
        {
            return _context.Clientes.Find(id);
        }

        // Read (all guests)
        public List<Cliente> GetAllGuests()
        {
            return _context.Clientes.ToList();
        }

        // Update
        public void UpdateGuest(Cliente guest)
        {
            _context.Clientes.Update(guest);
            _context.SaveChanges();
        }

        // Delete
        public void DeleteGuest(int id)
        {
            var guest = _context.Clientes.Find(id);
            if (guest != null)
            {
                _context.Clientes.Remove(guest);
                _context.SaveChanges();
            }
        }
    }
}
