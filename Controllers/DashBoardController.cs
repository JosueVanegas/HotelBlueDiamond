using Hotel.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Controllers
{
    public class DashBoardController
    {
        private readonly HotelContext _context;
        public DashBoardController(HotelContext context)
        {
            _context = context;
        }
        public async Task<int> HabitacionesTotales()
        {
            return await _context.Habitacions.CountAsync();
        }
        public async Task<int> HabitacionesDisponibles(int estado)
        {
             return await _context.Habitacions.Where(h=>h.EstadoId == estado).CountAsync();
        }
        public async Task<int?> CantidadHuespedes()
        {
            return await _context.Reservas.Where(r => r.Finalizada == false).SumAsync(r => r.CantidadPersonas);
        }
        public async Task<Dictionary<string, int?>> GraphicDataAsync()
        {
            var dic = await _context.DetallePedidos
                .Join(_context.Productos, dp => dp.ProductoId, p => p.ProductoId, (dp, p) => new { dp, p })
                .GroupBy(x => x.p.Descripcion)
                .Select(g => new { Descripcion = g.Key, Total = g.Sum(x => x.dp.Cantidad) })
                .OrderByDescending(x => x.Total)
                .Take(10)
                .ToDictionaryAsync(x => x.Descripcion, x => x.Total);

            return dic;
        }
    }
}
