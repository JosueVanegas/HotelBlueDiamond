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
        public int HabitacionesTotales()
        {
            int cantidad = _context.Habitacions.Count();
            return cantidad;
        }
        public int HabitacionesDisponibles(int estado)
        {
          
            return _context.Habitacions.Where(h=>h.EstadoId == estado).Count();
        }
        public int? CantidadHuespedes()
        {
            return _context.Reservas.Where(r => r.Finalizada == false).Sum(r => r.CantidadPersonas);
        }
        public Dictionary<string,int?> GraphicData()
        {
            var dic = _context.DetallePedidos
           .Join(_context.Productos, dp => dp.ProductoId,p => p.ProductoId, (dp, p) => new { dp, p })
           .GroupBy(x => x.p.Descripcion)
           .Select(g => new { Descripcion = g.Key, Total = g.Sum(x => x.dp.Cantidad) })
           .OrderByDescending(x => x.Total)
           .Take(10)
           .ToDictionary(x => x.Descripcion, x => x.Total);

            return dic;
        }
    }
}
