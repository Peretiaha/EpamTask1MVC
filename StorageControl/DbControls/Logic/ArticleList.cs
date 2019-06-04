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

            string s = list[0].ArticleText;
            
            for (int i = 0; i < list.Count; i++)
            {
                if (list[0].ArticleText.Length > 200) s = s.Remove(200, list[0].ArticleText.Length-200);
                list[0].ArticleText =  s;

            }



            return list;
        }


        public static Article SpesialArticle(int id)
        {
            
            Article ar = new Article();
            

            using (BlogDb db = new BlogDb())
            {
                foreach (var i in db.Artcle)
                {
                    if (i.ArticleId == id) ar = i;

                }
                ar.Tags = "Movie Vikings";
                

            }
            return ar;
        }
       



       


    }
}