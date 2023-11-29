using Hotel.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Controllers
{
    public class GraficasController
    {
        HotelContext _context;
        string mensaje = string.Empty;
        public GraficasController(HotelContext context)
        {
            this._context = context;
        }
        public List<Reserva> DatosReserva(DateTime fechaInicio, DateTime fechaFin)
        {
            var lista = new List<Reserva>();
            mensaje = "";

            try
            {
                lista = _context.Reservas
                    .Where(r => r.Finalizada == true && r.FechaRegistro > fechaInicio && r.FechaRegistro < fechaFin)
                    .Include(r => r.Habitacion)
                    .Include(r => r.Cliente)
                    .Include(r => r.Empleado)
                    .ToList();
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }

            return lista;
        }

        public decimal? DetallePedido(int reserva)
        {
            decimal? total = 0;
            var list = _context.Pedidos.Include(p=>p.DetallePedidos).Where(p => p.ReservaId == reserva).ToList();
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    foreach (var pedido in list)
                    {
                        
                        var listaD = _context.DetallePedidos.Include(dp=>dp.Producto).Where(dp=>dp.PedidoId == pedido.PedidoId).ToList();
                        foreach (var i in listaD)
                        {
                            total += i.Cantidad * i.Producto.Precio;
                        }
                    }
                }
                catch (Exception)
                {
                   total = 0;
                }
            }
            return total;
        }
        public decimal bonificacion(DateTime fechaInicio, DateTime fechaFin,int id)
        {
            decimal total = 0;
            var lista = new List<Asignacion>();
            lista = _context.Asignacions.Include(e=>e.Empleado).Where(e=>e.FechaConclusion > fechaInicio && e.FechaConclusion < fechaFin && e.EmpleadoId == id).ToList();
            foreach(Asignacion a in lista)
            {
                total += Convert.ToDecimal(a.ComisionGenerada);
            }
            return total;
        }
        public List<Empleado> DataNomina()
        {
            return _context.Empleados.Include(e=>e.Cargo).ToList();
        }
        public decimal calcularIR(decimal salariodevengado)
        {
            decimal salario = 0, INSS = 0, IR = 0, suma = 0, NETO, impuestoBase = 0, porcetajeAplicable = 0, sobreExceso = 0;
            if (salariodevengado != 0)
            {
                salario = salariodevengado;

                INSS = salario * Convert.ToDecimal(0.07);
                suma = salario - INSS;
                suma = suma * 12;

                if ((suma >= Convert.ToDecimal(0.01)) && (suma <= 100000))
                {
                    impuestoBase = 0;
                    porcetajeAplicable = 0;
                    sobreExceso = 0;
                }
                else if ((suma > 100000) && (suma <= 200000))
                {
                    impuestoBase = 0;
                    porcetajeAplicable = Convert.ToDecimal(0.15);
                    sobreExceso = 100000;
                }
                else if ((suma > 200000) && (suma <= 350000))
                {
                    impuestoBase = 15000;
                    porcetajeAplicable = Convert.ToDecimal(0.20);
                    sobreExceso = 200000;
                }
                else if ((suma > 350000) && (suma <= 500000))
                {
                    impuestoBase = 45000;
                    porcetajeAplicable = Convert.ToDecimal(0.25);
                    sobreExceso = 350000;
                }
                else if (suma > 500000)
                {
                    impuestoBase = 82500;
                    porcetajeAplicable = Convert.ToDecimal(0.30);
                    sobreExceso = 500000;
                }
                suma = suma - sobreExceso;
                suma = suma * porcetajeAplicable;
                suma = suma + impuestoBase;

                IR = suma / 12;
            }
            return IR;
        }
    }
}
