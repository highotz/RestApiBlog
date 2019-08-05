using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPIBlog.Models
{
    public class Usuario
    {
        public int id { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
        public string nome { get; set; }
        public string desc { get; set; }
    }
}
