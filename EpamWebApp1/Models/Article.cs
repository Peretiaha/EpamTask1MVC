using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpamWebApp1.Models
{
    public class Article
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }


       
        


        public Article(string Name, DateTime Date, string Text) {
            this.Name = Name;
            this.Date= Date;
            this.Text= Text;

        }


        


    }
}