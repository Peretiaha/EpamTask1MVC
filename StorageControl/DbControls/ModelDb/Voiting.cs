using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EpamWebApp1.Models
{
    public class Voiting
    {
        
            [Key]
            public int VId { get; set; }

            public string Choice { get; set; }


        
    }
}