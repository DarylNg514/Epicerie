using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace projetEpicerie.Models
{
    public class DbEpicerier:DbContext
    {
        public DbSet<boulangerie> boulangerie { get; set; }
        public DbSet<fruits_et_légumes> fruits_et_légumes { get; set; }
        public DbSet<viandes> viandes { get; set; }
        public DbSet<laitiers> laitiers { get; set; }
        public DbSet<user> user { get; set; }
        public DbSet<produitpanier> produitpanier { get; set; }
        public DbEpicerier()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<projetEpicerie.Models.DbEpicerier, projetEpicerie.Migrations.Configuration>());
        }

        public System.Data.Entity.DbSet<projetEpicerie.Models.Langues> Langues { get; set; }
    }
}