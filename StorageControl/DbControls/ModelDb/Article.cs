 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace EpamWebApp1.Models
{
    public class Article  //: IEnumerable<Article>
    {
        [Key]
        public int ArticleId { get; set;}   //Primary Key
        public string Name { get; set; }

        public DateTime date { get; set; }
        public string ArticleText{ get; set; }

        

        
    }
}