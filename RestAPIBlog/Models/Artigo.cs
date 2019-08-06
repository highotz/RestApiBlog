using System;

namespace RestAPIBlog.Models
{
    public class Artigo
    {
        public string permalink { get; set; }
        public string texto { get; set; }
        public string titulo { get; set; }
        public string subtitulo { get; set; }
        public DateTime dtPublicacao { get; set; }
        public DateTime dtEdicao { get; set; }

    }
}
