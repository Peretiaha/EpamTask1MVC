using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EpamWebApp1.Models;

namespace EpamWebApp1.Models
{
    public static class ArticleList
    {

        public static List<Article> LoadArticle()
        {
            var list =new List<Article>();
            using (BlogDb db = new BlogDb())
            {

                 list = db.Artcle.ToList();

            }

            return list;
        }

       



       


    }
}