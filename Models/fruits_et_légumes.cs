using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;


namespace projetEpicerie.Models
{
    public class fruits_et_légumes
    {
        [Key]
        public int id { get; set; }
        public string image { get; set; }
        public double prix { get; set; }
        public virtual List<Langues> Langue { get; set; } 

        //public virtual Langues anglais { get; set; }
        //public virtual Francais francais { get; set; }
    }
}