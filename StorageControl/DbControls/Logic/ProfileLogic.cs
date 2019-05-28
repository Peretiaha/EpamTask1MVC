using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StorageControl;

namespace EpamWebApp1.Models
{
    public static class ProfileLogic
    {

        public static List<Profile> LoadProfile()  //load all data from Comment table
        {
            var list = new List<Profile>();

            using(BlogDb db = new BlogDb())
            {
                list = db.Profile.ToList();
            }

            return list;

        }


        public static bool Add(Profile profile)  // add new comment
        {
            using (BlogDb db = new BlogDb())
            {
                if (db.Profile.Any(x => x.Name == profile.Name)) return false;

                db.Profile.Add(profile);
                db.SaveChanges();
                return true;
            }
        }

    }
}
