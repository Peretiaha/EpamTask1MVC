using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpamWebApp1.Models
{
    public class Profile
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Gender  { get; set; }

        public string Source { get; set; } //от куда узнали о блоге

        public List<string> SourceFav = new List<string> { "Google", "YouTube", "Facebook", "Other" }; // любимый жанр сериала

        public string[] SourceRes = new string[] { "Google", "YouTube", "Facebook" ,"Other"};

        public Dictionary<string, bool> FavoriteGenre  = new Dictionary<string, bool>();


    }
}