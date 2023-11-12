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
        public void UpdateObject(Reserva objects)
        {
            _context.Reservas.Update(objects);
            _context.SaveChanges();
        }
        public void DeleteObject(int id)
        {
            var objects = _context.Reservas.Find(id);
            if (objects != null)
            {
                _context.Reservas.Remove(objects);
                _context.SaveChanges();
            }
        }
        public Reserva GetObjectById(int id)
        {
            return _context.Reservas.Find(id);
        }
        public Reserva GetReservaByHabitacion(int id)
        {
            string query = @"select * from Reservas.Reserva
                     where Finalizada = 0 and HabitacionID = {0}";
            return _context.Reservas.FromSqlRaw(query, id).Include(r => r.Empleado).
                Include(r => r.Cliente).Include(r => r.Habitacion).Include(r=>r.Habitacion.CategoriaHabitacion)
                .Include(r=>r.Habitacion.Piso).FirstOrDefault();
        }
        public void SetState(int id,int state)
        {
            var obj = _context.Habitacions.Find(id);
            if(obj != null )
            {
                obj.EstadoId = state;
            }
        }
        public void UpdateServices(int reservaID)
        {
            var list = _context.Pedidos.Where(p=>p.ReservaId == reservaID).ToList();
            foreach (var i in list)
            {
               foreach (var j in i.DetallePedidos)
                {
                    
                }
            }
        }
        public List<Pedido> GetPedidoByHabitacion(int habitacionID)
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
