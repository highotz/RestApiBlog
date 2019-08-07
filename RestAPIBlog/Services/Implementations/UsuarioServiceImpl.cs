using System;
using System.Collections.Generic;
using System.Linq;
using RestAPIBlog.Models;
using RestAPIBlog.Models.Context;

namespace RestAPIBlog.Services.Implementations
{
    public class UsuarioServiceImpl : IUsuarioService
    {

        private MySQLContext _context;

        public UsuarioServiceImpl(MySQLContext context)
        {
            _context = context;
        }


        public Usuario Create(Usuario usuario)
        {
            try
            {
                    _context.Add(usuario);
                    _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }


            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            var result = _context.Usuarios.SingleOrDefault(u => u.id.Equals(id));

            try
            {
                if (result != null) _context.Usuarios.Remove(result);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Usuario> FindAll()
        {
            return _context.Usuarios.ToList();
        }

        public Usuario FindById(long id)
        {
            return _context.Usuarios.SingleOrDefault(u => u.id.Equals(id));
        }

        public Usuario Update(Usuario usuario)
        {
            if (!Exist(usuario.id)) return new Usuario();

            var result = _context.Artigos.SingleOrDefault(u => u.id.Equals(usuario.id));

            try
            {
                _context.Entry(result).CurrentValues.SetValues(usuario);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }


            return usuario;
        }

        private bool Exist(long? id)
        {
            return _context.Usuarios.Any(u => u.id.Equals(id));
        }
    }
}
