using RestAPIBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPIBlog.Services
{
    interface IArtigoService
    {
        Artigo Create(Artigo artigo);
        Artigo FindById(long id);
        List<Artigo> FindAll();
        Artigo Update(Artigo artigo);
        bool Delete(long id);
    }
}
