using Hotel.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Controllers
{
    public class PedidoControllercs
    {
        HotelContext _context;
        public PedidoControllercs(HotelContext context)
        {
            this._context = context;
        }
        public int AddObject(Pedido obj)
        {
            _context.Pedidos.Add(obj);
            _context.SaveChanges();
            return obj.PedidoId;
        }
        public List<Pedido> GetAllObject()
        {
            return _context.Pedidos.ToList();
        }
        public void UpdateObject(Pedido obj)
        {
            _context.Pedidos.Update(obj);
            _context.SaveChanges();
        }
        public void DeleteObject(int id)
        {
            var obj = GetObject(id);
            if (obj != null)
            {
                _context.Pedidos.Remove(obj);
                _context.SaveChanges();
            }
        }
        public Pedido GetObject(int id)
        {
            return _context.Pedidos.Find(id);
        }
        public void AddDetalles(DetallePedido obj)
        {
            _context.DetallePedidos.Add(obj);
            _context.SaveChanges();
        }
        public void CancelarPedido(int id)
        {
            var obj = _context.Pedidos.Include(p=>p.ReservaId == id).FirstOrDefault();
            if(obj != null)
            {
                obj.Estado = true;
                _context.SaveChanges();
            }
        }

    }
}
