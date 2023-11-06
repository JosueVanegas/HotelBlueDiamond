using Hotel_Dorado_DesktopApp.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Dorado_DesktopApp.Controllers
{
    public class UsuarioController
    {
        HotelDoradoContext _context;

        public UsuarioController(HotelDoradoContext context)
        {
            this._context = context;
        }
        public void AddObject(Usuario obj)
        {
            _context.Usuarios.Add(obj);
            _context.SaveChanges();
        }
        public List<Usuario> GetAllObject()
        {
            return _context.Usuarios.ToList();
        }
        public void UpdateObject(Usuario obj)
        {
            _context.Usuarios.Update(obj);
            _context.SaveChanges();
        }
        public void DeleteObject(int id)
        {
            var obj = _context.Usuarios.Find(id);
            if (obj != null)
            {
                _context.Usuarios.Remove(obj);
                _context.SaveChanges();
            }
        }

        public bool GetValue(string usuario, string clave)
        {
            var usuarioParam = new SqlParameter("@Usuario", usuario);
            var claveParam = new SqlParameter("@Clave", clave);
            var permitirParam = new SqlParameter
            {
                ParameterName = "@Permitir",
                SqlDbType = SqlDbType.Bit,
                Direction = ParameterDirection.Output
            };

            _context.Database.ExecuteSqlRaw($"EXEC dbo.PROC_READ_ENCRYP_PASSWORD @Usuario, @Clave, @Permitir OUTPUT",usuarioParam,claveParam,permitirParam);

            return (bool)permitirParam.Value;
        }
    }
}
