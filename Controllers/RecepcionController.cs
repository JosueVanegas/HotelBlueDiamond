﻿using Hotel_Dorado_DesktopApp.Models;
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
            return _context.Reservas.ToList();
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

    }
}