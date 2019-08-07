using System;
using System.Collections.Generic;
using System.Linq;
using RestAPIBlog.Models;
using RestAPIBlog.Models.Context;

namespace RestAPIBlog.Services.Implementations
{
    public class ComentarioServiceImpl : IComentarioService
    {

        private MySQLContext _context;

        public ComentarioServiceImpl(MySQLContext context)
        {
            _context = context;
        }

        public Comentario Create(Comentario comentario)
        {

            try
            {
                _context.Add(comentario);
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
            var result = _context.Comentarios.SingleOrDefault(c => c.id.Equals(id));

            try
            {
                if (result != null) _context.Comentarios.Remove(result);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Comentario> FindAll()
        {
            return _context.Comentarios.ToList();
        }

        public Comentario FindById(long id)
        {
            return _context.Comentarios.SingleOrDefault(c => c.id.Equals(id));
        }

        public Comentario Update(Comentario comentario)
        {
            if (!Exist(comentario.id)) return new Comentario();

            var result = _context.Comentarios.SingleOrDefault(a => a.id.Equals(comentario.id));

            try
            {
                _context.Entry(result).CurrentValues.SetValues(comentario);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }


            return comentario;
        }

        private bool Exist(int id)
        {
            return _context.Comentarios.Any(c => c.id.Equals(id));
        }
    }
}
