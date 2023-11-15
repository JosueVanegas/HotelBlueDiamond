using Hotel.Models;
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

namespace Hotel.Controllers
{
    public class UsuarioController
    {
        HotelContext _context;

        public UsuarioController(HotelContext context)
        {
            this._context = context;
        }
        public async void AddObject(Usuario obj)
        {
            _context.Usuarios.Add(obj);
            _context.SaveChangesAsync();
        }
        public async Task<List<Usuario>> GetAllObject()
        {
            return await _context.Usuarios.Include(u=>u.Empleado).Include(u=>u.Rol).ToListAsync();
        }
        public async void UpdateObject(Usuario obj)
        {
            _context.Usuarios.Update(obj);
            _context.SaveChangesAsync();
        }
        public async void DeleteObject(int id)
        {
            var obj = await _context.Usuarios.FindAsync(id);
            if (obj != null)
            {
                _context.Usuarios.Remove(obj);
                _context.SaveChangesAsync();
            }
        }
        public Usuario GetObjectByUser(string usuario)
        {
            var user =  _context.Usuarios.Include(u => u.Rol).Include(u => u.Empleado).Where(u => u.Usuario1 == usuario).FirstOrDefault();
            return user;
        }
        public async Task<Usuario> GetObjectById(int id)
        {
            var user = await _context.Usuarios.Include(u => u.Rol).Include(u => u.Empleado).Where(u=>u.UsuarioId == id).FirstOrDefaultAsync();
            return user;
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

            return  (bool)permitirParam.Value;
        }
    }
}
