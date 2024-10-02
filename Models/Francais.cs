using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace projetEpicerie.Models
{
    public class Francais
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }
}