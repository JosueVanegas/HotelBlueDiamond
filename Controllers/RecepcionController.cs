using Hotel_Dorado_DesktopApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Dorado_DesktopApp.Controllers
{
    public class RecepcionController
    {
        private readonly HotelDoradoContext _context;

        public RecepcionController(HotelDoradoContext context)
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
                Include(r => r.Cliente).Include(r => r.Habitacion).FirstOrDefault();
        }
        public List<Pedido> GetPedidoByHabitacion(int habitacionID)
        {
            string query = @"select sd.PedidoID,pp.Descripcion,pp.Precio,sd.Cantidad from Servicios.Pedido sp
                            join Servicios.DetallePedido sd on sd.PedidoID = sp.PedidoID
                            join Reservas.Reserva rr on sp.ReservaID = rr.ReservaID
                            join Servicios.Producto pp on pp.ProductoID = sd.ProductoID
                            where rr.HabitacionID = {0} and rr.Finalizada = 0";
                 return _context.Pedidos.FromSqlRaw(query, habitacionID).Include(r => r.DetallePedidos).ToList();
        }
        
    }
}
