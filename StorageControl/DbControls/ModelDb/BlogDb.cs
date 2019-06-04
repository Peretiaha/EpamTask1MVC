using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace EpamWebApp1.Models
{
    public class BlogDb : DbContext
    {
        public BlogDb() : base ("BlogDb")
        {

        }

        public DbSet<Article> Artcle{ get; set; }    //Table Article
        public DbSet<Profile> Profile{ get; set; }      //Table Profile
        public DbSet<Comments> Comments{ get; set; }    //Table Comments
        public DbSet<Voiting> Voiting { get; set; }


    }
}