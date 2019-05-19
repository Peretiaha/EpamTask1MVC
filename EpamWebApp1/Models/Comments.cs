using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpamWebApp1.Models
{
    public class Comments
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }

        public Comments(string name, DateTime date, string text)
        {
            this.Name = name;
            this.Date = date;
            this.Text = text;
        }
             
        
    }
}