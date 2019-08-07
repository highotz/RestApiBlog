using RestAPIBlog.Models;
using System.Collections.Generic;

namespace RestAPIBlog.Services
{
    public interface IComentarioService
    {
        Comentario Create(Comentario comentario);
        Comentario FindById(long id);
        List<Comentario> FindAll();
        Comentario Update(Comentario comentario);
        void Delete(long id);
    }
}
