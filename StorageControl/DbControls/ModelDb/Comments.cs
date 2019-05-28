using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EpamWebApp1.Models
{
    public class Comments
    {
        [Key]
        public int CommentId { get; set; } //PRIMARY KEY
        
        public string UserName { get; set; }

        public DateTime date { get; set; }

        public string CommentText { get; set; }


        public Comments()      //determine the current date
        {
            date = DateTime.Now;
        }
    }
}