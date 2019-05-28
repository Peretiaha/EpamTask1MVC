using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpamWebApp1.Models
{
    public static class CommentsList
    {
       
        public static List<Comments> LoadComments()  //load all data from Comment table
        {
            var comments = new List<Comments>();

            using (BlogDb db = new BlogDb())
            {
                comments = db.Comments.ToList();
            }

            return comments;
        }


        public static bool Add(Comments comment)  // add new comment
        {
            using (BlogDb db = new BlogDb())
            {
                if (db.Comments.Any(x => x.UserName == comment.UserName && x.CommentText == comment.CommentText)) return false;
                                     
                db.Comments.Add(comment);
                db.SaveChanges();
                return true;
            }
        }

        
    }
}