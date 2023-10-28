using Hotel_Dorado_DesktopApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Dorado_DesktopApp.Controllers
{
    public class DashBoardController
    {
        private readonly HotelDoradoContext _context;
        public DashBoardController(HotelDoradoContext context)
        {
            _context = context;
        }
        public int Habitaciones()
        {
            int cantidad = _context.Habitacions.Count();
            return cantidad;
        }
        public int HabitacionesDisponibles(string estado)
        {
            string query = "select count(*) from Habitaciones.Habitacion where ";
            return _context.Habitacions.FromSqlRaw(query).AsEnumerable().Count();
        }
    }
}
