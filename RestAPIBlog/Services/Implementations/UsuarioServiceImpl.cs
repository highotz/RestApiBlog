using System;
using System.Collections.Generic;
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

        public bool Delete(long id)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> FindAll()
        {
            throw new NotImplementedException();
        }

        public Usuario FindById(long id)
        {
            throw new NotImplementedException();
        }

        public Usuario Update(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
