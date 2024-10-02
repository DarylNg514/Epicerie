using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace projetEpicerie.Models
{
    public class user
    {
        [Key]
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int titre { get; set; }
    }
}