using RestAPIBlog.Models;
using System.Collections.Generic;

namespace RestAPIBlog.Services
{
    public interface IArtigoService
    {
        Artigo Create(Artigo artigo);
        Artigo FindById(long id);
        List<Artigo> FindAll();
        Artigo Update(Artigo artigo);
        bool Delete(long id);
    }
}
