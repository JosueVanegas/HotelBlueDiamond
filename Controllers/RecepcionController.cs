using Hotel.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Controllers
{
    public class RecepcionController
    {
        private readonly HotelContext _context;

        public RecepcionController(HotelContext context)
        {
            _context = context;
        }
        public void AddObject(Reserva objects)
        {
            _context.Reservas.Add(objects);
            _context.SaveChanges();
        }
        public List<Reserva> GetAllObjects()
        {
            return _context.Reservas.Include(r=>r.Empleado).Include(r=>r.Cliente).Include(r=>r.Habitacion).ToList();
        }
        public  void UpdateReservaObject(Reserva objects)
        {
            _context.Reservas.Update(objects); 
            _context.SaveChangesAsync();
        }
        public Reserva GetObjectById(int id)
        {
            return _context.Reservas.Find(id);
        }
        public Reserva GetReservaByHabitacion(int? id)
        {
            string query = @"select * from Reservas.Reserva
                     where Finalizada = 0 and HabitacionID = {0}";
            return _context.Reservas.FromSqlRaw(query, id).Include(r => r.Empleado).
                Include(r => r.Cliente).Include(r => r.Habitacion).Include(r=>r.Habitacion.CategoriaHabitacion)
                .Include(r=>r.Habitacion.Piso).FirstOrDefault();
        }
        
        public void UpdateServices(int reservaID)
        {
            var list = _context.Pedidos.Where(p => p.ReservaId == reservaID).ToList();
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    foreach (var pedido in list)
                    {
                        pedido.Estado = true;
                    }

                    _context.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
        public List<Pedido> GetPedidoByHabitacion(int? habitacionID)
        {
            var pedidos = _context.Pedidos
            .Where(p => p.Reserva.HabitacionId == habitacionID && p.Reserva.Finalizada == false)
            .Include(r=>r.Reserva)
            .Include(p => p.DetallePedidos)
            .ThenInclude(dp => dp.Producto)
            .ToList();
            return pedidos;
        }
        
    }
}
