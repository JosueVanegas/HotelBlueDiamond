using Hotel.Models;
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
        public void AddObject(Pedido obj)
        {
            _context.Pedidos.Add(obj);
            _context.SaveChanges();
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

    }
}
