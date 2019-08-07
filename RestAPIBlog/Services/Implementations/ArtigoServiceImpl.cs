using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using RestAPIBlog.Models;
using RestAPIBlog.Models.Context;

namespace RestAPIBlog.Services.Implementations
{
    public class ArtigoServiceImpl : IArtigoService
    {

        private MySQLContext _context;

        public ArtigoServiceImpl(MySQLContext context)
        {
            _context = context;
        }

        public Artigo Create(Artigo artigo)
        {
            var slug = artigo.permalink;

            artigo.permalink = GenerateSlug(slug);

            try
            {
                _context.Add(artigo);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }


            return artigo;
        }

        public void Delete(long id)
        {
            var result = _context.Artigos.SingleOrDefault(a => a.id.Equals(id));

            try
            {
                if(result != null) _context.Artigos.Remove(result);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Artigo> FindAll()
        {
            return _context.Artigos.ToList();
        }

        public Artigo FindById(long id)
        {
            return _context.Artigos.SingleOrDefault(a => a.id.Equals(id));
        }

        public Artigo Update(Artigo artigo)
        {
            if (!Exist(artigo.id)) return new Artigo();

            var result = _context.Artigos.SingleOrDefault(a => a.id.Equals(artigo.id));

            try
            {
                _context.Entry(result).CurrentValues.SetValues(artigo);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }


            return artigo;
        }

        private bool Exist(long id)
        {
            return _context.Artigos.Any(a => a.id.Equals(id));
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
