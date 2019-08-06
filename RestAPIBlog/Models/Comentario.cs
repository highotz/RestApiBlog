using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPIBlog.Models
{
    public class Comentario
    {
        public int id { get; set; }
        public string texto { get; set; }
        public int autor { get; set; }
        public int idArtigo { get; set; }
    }
}
