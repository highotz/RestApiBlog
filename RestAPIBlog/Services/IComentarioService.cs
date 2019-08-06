using RestAPIBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPIBlog.Services
{
    interface IComentarioService
    {
        Comentario Create(Comentario comentario);
        Comentario FindById(long id);
        List<Comentario> FindAll();
        Comentario Update(Comentario comentario);
        bool Delete(long id);
    }
}
