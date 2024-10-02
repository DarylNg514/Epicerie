using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using projetEpicerie.Models;

namespace projetEpicerie.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            DbEpicerier db = new DbEpicerier();

            Langues anglaisl1 = new Langues { id = 1, symbol = "EN", name = "Cheese", description = "My name is Cheese" };
            Langues francaisl1 = new Langues { id = 2, symbol = "FR", name = "Fromage", description = "Mon nom est Fromage " };
            Langues anglaisl2 = new Langues { id = 3, symbol = "EN", name = "Eggs", description = "My name is Eggs" };
            Langues francaisl2 = new Langues { id = 4, symbol = "FR", name = "oeufs", description = "Mon nom est oeufs " };

            Langues anglaisb1 = new Langues { id = 5, symbol = "EN", name = "Bread", description = "My name is Bread" };
            Langues francaisb1 = new Langues { id = 6, symbol = "FR", name = "pain", description = "Mon nom est Pain " };
            Langues anglaisb2 = new Langues { id = 7, symbol = "EN", name = "Cake", description = "My name is Cake" };
            Langues francaisb2 = new Langues { id = 8, symbol = "FR", name = "Gateaux", description = "Mon nom est Gateaux " };

            Langues anglaisv1 = new Langues { id = 9, symbol = "EN", name = "Chicken", description = "My name is Chicken" };
            Langues francaisv1 = new Langues { id = 10, symbol = "FR", name = "Poulet", description = "Mon nom est Poulet " };
            Langues anglaisv2 = new Langues { id = 11, symbol = "EN", name = "Pig", description = "My name is Pig" };
            Langues francaisv2 = new Langues { id = 12, symbol = "FR", name = "Porc", description = "Mon nom est Porc " };

            Langues anglaisfl1 = new Langues { id = 13, symbol = "EN", name = "Apple", description = "My name is Apple" };
            Langues francaisfl1 = new Langues { id = 14, symbol = "FR", name = "Pomme", description = "Mon nom est Pomme " };
            Langues anglaisfl2 = new Langues { id = 15, symbol = "EN", name = "Banana", description = "My name is Banana" };
            Langues francaisfl2 = new Langues { id = 16, symbol = "FR", name = "Banane", description = "Mon nom est Banane " };

            laitiers l1 = new laitiers
            {
                id = 1,
                image = "",
                prix = 15.05,
                Langue = new List<Langues> { anglaisl1, francaisl1 }
            };
            laitiers l2 = new laitiers
            {
                id = 2,
                image = "",
                prix = 12.35,
                Langue = new List<Langues> { anglaisl2, francaisl2 }

            };

            boulangerie b1 = new boulangerie
            {
                id = 1,
                image = "",
                prix = 7.05,
                Langue = new List<Langues> { anglaisb1, francaisb1 }
            };
            boulangerie b2 = new boulangerie
            {
                id = 2,
                image = "",
                prix = 32.05,
                Langue = new List<Langues> { anglaisb2, francaisb2 }

            };

            viandes v1 = new viandes
            {
                id = 1,
                image = "",
                prix = 17.05,
                Langue = new List<Langues> { anglaisv1, francaisv1 }
            };
            viandes v2 = new viandes
            {
                id = 2,
                image = "",
                prix = 26.15,
                Langue = new List<Langues> { anglaisv2, francaisv2 }

            };

            fruits_et_légumes fl1 = new fruits_et_légumes
            {
                id = 1,
                image = "",
                prix = 14.73,
                Langue = new List<Langues> { anglaisfl1, francaisfl1 }
            };
            fruits_et_légumes fl2 = new fruits_et_légumes
            {
                id = 2,
                image = "",
                prix = 3.48,
                Langue = new List<Langues> { anglaisfl2, francaisfl2 }

            };

            db.laitiers.Add(l1);
            db.laitiers.Add(l2);

            db.boulangerie.Add(b1);
            db.boulangerie.Add(b2);

            db.viandes.Add(v1);
            db.viandes.Add(v2);

            db.fruits_et_légumes.Add(fl1);
            db.fruits_et_légumes.Add(fl2);

            db.SaveChanges();
            return View();
        }

        public ActionResult Acceuil()
        {
            DbEpicerier db = new DbEpicerier();
            ViewBag.laitier = "Produits Laitiers";
            ViewBag.boulangerie = "Produits Boulangerie";
            ViewBag.viande = "Produits Viandes";
            ViewBag.fruit_legume = "Produits Fruits et Légumes";
            ViewBag.p1 = "Bienvenue dans le system de gestion de L'inventaire des materiels";
            ViewBag.p2 = "Veuillez choisir une categorie si dessus...";
            return View();
        }

        [HttpPost]
        public ActionResult Acceuil(string Id)
        {
            return View("Acceuil");
        }


        public ActionResult translateAccuielA()
        {
            DbEpicerier db = new DbEpicerier();
            ViewBag.laitier = "Dairy Products";
            ViewBag.boulangerie = "Bakery Products";
            ViewBag.viande = "Meat Products";
            ViewBag.fruit_legume = "Fruit and Vegetable Products";
            ViewBag.p1 = "Welcome to the Material Inventory Management System";
            ViewBag.p2 = "Please choose a category if above...";
            return View("Acceuil");
        }
        [HttpPost]

        public ActionResult translateAccuielA(string id)
        {
            return View("Acceuil");
        }

        public ActionResult translateAccuielF()
        {
            DbEpicerier db = new DbEpicerier();
            ViewBag.laitier = "Produits Laitiers";
            ViewBag.boulangerie = "Produits Boulangerie";
            ViewBag.viande = "Produits Viandes";
            ViewBag.fruit_legume = "Produits Fruits et Légumes";
            ViewBag.p1 = "Bienvenue dans le system de gestion de L'inventaire des materiels";
            ViewBag.p2 = "Veuillez choisir une categorie si dessus...";

            return View("Acceuil");
        }
        [HttpPost]

        public ActionResult translateAccuielF(string id)
        {
            return View("Acceuil");
        }

        

        public ActionResult translateAnglais()
        {
            DbEpicerier db = new DbEpicerier();

            foreach (var l in db.laitiers)
            {
                foreach (var lan in l.Langue)
                {
                    ViewBag.Aname = lan.name;
                    ViewBag.Adesc = lan.description;
                }
            }
            ViewBag.msgeqp = db.laitiers;
            return View(db.laitiers);
        }
        [HttpPost]

        public ActionResult translateAnglais(string id)
        {
            return View(new laitiers { });
        }

        public ActionResult translateFrancais()
        {
            DbEpicerier db = new DbEpicerier();

            foreach (var l in db.laitiers)
            {
                foreach (var lan in l.Langue)
                {
                    ViewBag.Fname = lan.name;
                    ViewBag.Fdesc = lan.description;
                }
            }
            ViewBag.msgeqp = db.laitiers;

            return View(db.laitiers);
        }
        [HttpPost]

        public ActionResult translateFrancais(string id)
        {
            return View(new laitiers { });
        }

        public ActionResult Laitiers(string Langue)
        {
            DbEpicerier db = new DbEpicerier();
            ViewBag.msgepi = db.laitiers;
            ViewBag.langue= Langue;
            return View(db.laitiers);
        }
        [HttpPost]

        public ActionResult Laitiers()
        {
            return View(new laitiers { });
        }

        public ActionResult Boulangerie()
        {
            DbEpicerier db = new DbEpicerier();


            foreach (var l in db.boulangerie)
            {
                foreach (var lan in l.Langue)
                {
                    ViewBag.Fname = lan.name;
                    ViewBag.Fdesc = lan.description;
                }
            }
            ViewBag.msgepi = db.boulangerie;
            return View(db.boulangerie);
        }
        [HttpPost]

        public ActionResult Boulangerie(string id)
        {
            return View(new boulangerie { });
        }

        public ActionResult Viandes()
        {
            DbEpicerier db = new DbEpicerier();


            foreach (var l in db.viandes)
            {
                foreach (var lan in l.Langue)
                {
                    ViewBag.Fname = lan.name;
                    ViewBag.Fdesc = lan.description;
                }
            }
            ViewBag.msgepi = db.viandes;
            return View(db.viandes);
        }
        [HttpPost]

        public ActionResult Viandes(string id)
        {
            return View(new viandes { });
        }

        public ActionResult Fruits_et_Légumes()
        {
            DbEpicerier db = new DbEpicerier();


            foreach (var l in db.fruits_et_légumes)
            {
                foreach (var lan in l.Langue)
                {
                    ViewBag.Fname = lan.name;
                    ViewBag.Fdesc = lan.description;
                }
            }
            ViewBag.msgepi = db.fruits_et_légumes;
            return View(db.fruits_et_légumes);
        }
        [HttpPost]

        public ActionResult Fruits_et_Légumes(string id)
        {
            return View(new fruits_et_légumes { });
        }

    }
}