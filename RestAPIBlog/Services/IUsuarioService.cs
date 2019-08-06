using RestAPIBlog.Models;
using System.Collections.Generic;

namespace RestAPIBlog.Services
{
    public interface IUsuarioService
    {
        Usuario Create(Usuario usuairo, string confirmaSenha);
        Usuario FindById(long id);
        List<Usuario> FindAll();
        Usuario Update(Usuario usuario);
        bool Delete(long id);
    }
}
