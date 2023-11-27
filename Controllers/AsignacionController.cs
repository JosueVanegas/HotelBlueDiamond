using Hotel.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Controllers
{
    public class AsignacionController
    {
        HotelContext _context;
        public AsignacionController (HotelContext context)
        {
            this._context = context;
        }
        public void AddObject(Asignacion obj)
        {
            _context.Asignacions.Add(obj);
            _context.SaveChanges();
        }
        public List<Asignacion> GetAllObjects()
        {
            return _context.Asignacions.ToList();
        }
        public void UpdateObject(Asignacion obj)
        {
            _context.Asignacions.Update(obj);
            _context.SaveChanges();
        }
        public void DeleteObject(int id)
        {
            var obj = _context.Asignacions.Find(id);
            if (obj != null)
            {
                _context.Asignacions.Remove(obj);
                _context.SaveChanges();
            }
        }
        public Asignacion GetObjectByHabId(int id)
        {
            return _context.Asignacions.Include(a=>a.Empleado).Include(a=>a.Habitacion)
                .Include(a => a.Habitacion.CategoriaHabitacion)
                .Include(a => a.Habitacion.Piso)
                .Include(a=>a.Habitacion.Estado)
                .Where(a => a.HabitacionId == id && a.Estado == false)
                .FirstOrDefault();
        }
        public List<EstadoHabitacion> GetStatesH()
        {
            return _context.EstadoHabitacions.ToList();
        }
        public void ChangeHabEstate(int? idH,int estado)
        {
            var obj = _context.Habitacions.Find(idH);
            if (obj != null)
            {
                obj.EstadoId = estado;
                _context.SaveChanges();
            }
        }
    }
}
