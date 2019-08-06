using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using RestAPIBlog.Models;

namespace RestAPIBlog.Services.Implementations
{
    public class ArtigoServiceImpl : IArtigoService
    {
        public Artigo Create(Artigo artigo)
        {
            return artigo;
        }

        public bool Delete(long id)
        {
            throw new NotImplementedException();
        }

        public List<Artigo> FindAll()
        {
            throw new NotImplementedException();
        }

        public Artigo FindById(long id)
        {
            Artigo artigo = new Artigo();

            return artigo;
        }

        public Artigo Update(Artigo artigo)
        {
            return artigo;
        }

        public static string GenerateSlug(string phrase)
        {
            string str = RemoveAccent(phrase).ToLower();
            // invalid chars           
            str = Regex.Replace(str, @"[^a-z0-9\s-]", "");
            // convert multiple spaces into one space   
            str = Regex.Replace(str, @"\s+", " ").Trim();
            // cut and trim 
            str = str.Substring(0, str.Length <= 45 ? str.Length : 45).Trim();
            str = Regex.Replace(str, @"\s", "-"); // hyphens   
            return str + DateTime.Now.ToString("yyyyMMddHHmmssffff");
        }

        public static string RemoveAccent(string txt)
        {
            byte[] bytes = System.Text.Encoding.GetEncoding("Cyrillic").GetBytes(txt);
            return System.Text.Encoding.ASCII.GetString(bytes);
        }
    }
}
