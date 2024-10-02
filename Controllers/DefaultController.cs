using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

            user us1 = new user 
            {
                username = "Daryl",
                password="0000",
                titre=1
            };
            user us2 = new user
            {
                username = "Steevy",
                password = "1111",
                titre = 0
            };
            db.user.Add(us1);
            db.user.Add(us2);


            Langues anglaisl1 = new Langues { id = 1, symbol = "EN", name = "Cheese", description = "My name is Cheese" };
            Langues francaisl1 = new Langues { id = 2, symbol = "FR", name = "Fromage", description = "Mon nom est Fromage " };
            Langues anglaisl2 = new Langues { id = 3, symbol = "EN", name = "Eggs", description = "My name is Eggs" };
            Langues francaisl2 = new Langues { id = 4, symbol = "FR", name = "oeufs", description = "Mon nom est oeufs " };
            Langues anglaisl3 = new Langues { id = 5, symbol = "EN", name = "Yogourt", description = "My name is yogourt" };
            Langues francaisl3 = new Langues { id = 6, symbol = "FR", name = "Yaourt", description = "Mon nom est yaourt " };
            Langues anglaisl4 = new Langues { id = 7, symbol = "EN", name = "Milk", description = "My name is Milk" };
            Langues francaisl4 = new Langues { id = 8, symbol = "FR", name = "lait", description = "Mon nom est Lait " };
            Langues anglaisl5 = new Langues { id = 9, symbol = "EN", name = " organic Milk", description = "My name is Milk" };
            Langues francaisl5 = new Langues { id = 10, symbol = "FR", name = "lait biologique", description = "Mon nom est Lait " };
            Langues anglaisl6 = new Langues { id = 11, symbol = "EN", name = " Yogourt fruit", description = "My name is Yogourt fruit" };
            Langues francaisl6 = new Langues { id = 12, symbol = "FR", name = "Yogourt fruit", description = "Mon nom est Yogourt fruit " };
            Langues anglaisl7 = new Langues { id = 13, symbol = "EN", name = " Yogourt", description = "My name is Yogourt" };
            Langues francaisl7 = new Langues { id = 14, symbol = "FR", name = "Yogourt", description = "Mon nom est Yogourt" };
            Langues anglaisl8 = new Langues { id = 15, symbol = "EN", name = " Sognon cheese", description = "My name is Sognon cheese" };
            Langues francaisl8 = new Langues { id = 16, symbol = "FR", name = "Fromage sognon", description = "Mon nom est Fromage sognon" };


            Langues anglaisb1 = new Langues { id = 17, symbol = "EN", name = "Bread", description = "My name is Bread" };
            Langues francaisb1 = new Langues { id = 18, symbol = "FR", name = "pain", description = "Mon nom est Pain " };
            Langues anglaisb2 = new Langues { id = 19, symbol = "EN", name = "Cake", description = "My name is Cake" };
            Langues francaisb2 = new Langues { id = 20, symbol = "FR", name = "Gateaux", description = "Mon nom est Gateaux " };
            Langues anglaisb3 = new Langues { id = 21, symbol = "EN", name = "Cake", description = "My name is Cake" };
            Langues francaisb3 = new Langues { id = 22, symbol = "FR", name = "Gateaux", description = "Mon nom est Gateaux " };
            Langues anglaisb4 = new Langues { id = 23, symbol = "EN", name = "Cake", description = "My name is Cake" };
            Langues francaisb4 = new Langues { id = 24, symbol = "FR", name = "Gateaux", description = "Mon nom est Gateaux " };
            Langues anglaisb5 = new Langues { id = 25, symbol = "EN", name = "Cake", description = "My name is Cake" };
            Langues francaisb5 = new Langues { id = 26, symbol = "FR", name = "Gateaux", description = "Mon nom est Gateaux " };
            Langues anglaisb6 = new Langues { id = 27, symbol = "EN", name = "Cake", description = "My name is Cake" };
            Langues francaisb6 = new Langues { id = 28, symbol = "FR", name = "Gateaux", description = "Mon nom est Gateaux " };
            Langues anglaisb7 = new Langues { id = 29, symbol = "EN", name = "Cake", description = "My name is Cake" };
            Langues francaisb7 = new Langues { id = 30, symbol = "FR", name = "Gateaux", description = "Mon nom est Gateaux " };


            Langues anglaisv1 = new Langues { id = 31, symbol = "EN", name = "Chicken", description = "My name is Chicken" };
            Langues francaisv1 = new Langues { id = 32, symbol = "FR", name = "Poulet", description = "Mon nom est Poulet " };
            Langues anglaisv2 = new Langues { id = 33, symbol = "EN", name = "Pig", description = "My name is Pig" };
            Langues francaisv2 = new Langues { id = 34, symbol = "FR", name = "Porc", description = "Mon nom est porc " };
            Langues anglaisv3 = new Langues { id = 35, symbol = "EN", name = "lamb", description = "My name is lamb" };
            Langues francaisv3 = new Langues { id = 36, symbol = "FR", name = "Agneau", description = "Mon nom est Agneau " };
            Langues anglaisv4 = new Langues { id = 37, symbol = "EN", name = "beef", description = "My name is beef" };
            Langues francaisv4 = new Langues { id = 38, symbol = "FR", name = "Beouf", description = "Mon nom est Beouf " };
            Langues anglaisv5 = new Langues { id = 39, symbol = "EN", name = "minced", description = "My name is minced" };
            Langues francaisv5 = new Langues { id = 40, symbol = "FR", name = "Haché", description = "Mon nom est Haché " };
            Langues anglaisv6 = new Langues { id = 41, symbol = "EN", name = "Salami", description = "My name is salami" };
            Langues francaisv6 = new Langues { id = 42, symbol = "FR", name = "Salami", description = "Mon nom est salami " };
            Langues anglaisv7 = new Langues { id = 43, symbol = "EN", name = "Sausage", description = "My name is sausage" };
            Langues francaisv7 = new Langues { id = 44, symbol = "FR", name = "Saucisson", description = "Mon nom est saucisson " };


            Langues anglaisfl1 = new Langues { id = 45, symbol = "EN", name = "Apple", description = "My name is Apple" };
            Langues francaisfl1 = new Langues { id = 46, symbol = "FR", name = "Pomme", description = "Mon nom est Pomme " };
            Langues anglaisfl2 = new Langues { id = 47, symbol = "EN", name = "Banana", description = "My name is Banana" };
            Langues francaisfl2 = new Langues { id = 48, symbol = "FR", name = "Banane", description = "Mon nom est Banane " };
            Langues anglaisfl3 = new Langues { id = 49, symbol = "EN", name = "Celeri", description = "My name is Celeri" };
            Langues francaisfl3 = new Langues { id = 50, symbol = "FR", name = "Celeri", description = "Mon nom est Celeri " };
            Langues anglaisfl4 = new Langues { id = 51, symbol = "EN", name = "Pepper", description = "My name is Pepper" };
            Langues francaisfl4 = new Langues { id = 52, symbol = "FR", name = "Poivrons", description = "Mon nom est Poivrons " };
            Langues anglaisfl5 = new Langues { id = 53, symbol = "EN", name = "Kiwi", description = "My name is Kiwi" };
            Langues francaisfl5 = new Langues { id = 54, symbol = "FR", name = "Kiwi", description = "Mon nom est Kiwi " };
            Langues anglaisfl6 = new Langues { id = 55, symbol = "EN", name = "Onions", description = "My name is onions" };
            Langues francaisfl6 = new Langues { id = 56, symbol = "FR", name = "Ognions", description = "Mon nom est ognions " };
            Langues anglaisfl7 = new Langues { id = 57, symbol = "EN", name = "Carrot", description = "My name is carrot" };
            Langues francaisfl7 = new Langues { id = 58, symbol = "FR", name = "Carotte", description = "Mon nom est carotte " };
            Langues anglaisfl8 = new Langues { id = 57, symbol = "EN", name = "Fraise", description = "My name is fraise" };
            Langues francaisfl8 = new Langues { id = 58, symbol = "FR", name = "Straubery", description = "Mon nom est straubery " };

            laitiers l1 = new laitiers
                {
            id = 1,
            image = "../images/frommage.jpg",
            prix = 15.05,
            Langue = new List<Langues> { anglaisl1, francaisl1 }
             };
            laitiers l2 = new laitiers
            {
                id = 2,
                image = "../images/oeuf.jpg",
                prix = 12.35,
                Langue = new List<Langues> { anglaisl2, francaisl2 }

            };
            laitiers l3 = new laitiers
            {
                id = 3,
                image = "../images/yaourt.jpg",
                prix = 12.35,
                Langue = new List<Langues> { anglaisl3, francaisl3 }

            };
            laitiers l4 = new laitiers
            {
                id = 4,
                image = "../images/lait.jpg",
                prix = 12.35,
                Langue = new List<Langues> { anglaisl4, francaisl4 }

            };
            laitiers l5 = new laitiers
            {
                id = 5,
                image = "../images/lait_bio.jpg",
                prix = 12.35,
                Langue = new List<Langues> { anglaisl5, francaisl5 }

            };
            laitiers l6 = new laitiers
            {
                id = 6,
                image = "../images/yaourt_F.jpg",
                prix = 12.35,
                Langue = new List<Langues> { anglaisl6, francaisl6 }

            };
            laitiers l7 = new laitiers
            {
                id = 7,
                image = "../images/yogourt.jpg",
                prix = 12.35,
                Langue = new List<Langues> { anglaisl7, francaisl7 }

            };
            laitiers l8 = new laitiers
            {
                id = 8,
                image = "../images/from_sognon.jpg",
                prix = 12.35,
                Langue = new List<Langues> { anglaisl8, francaisl8 }

            };

            boulangerie b1 = new boulangerie
            {
                id = 1,
                image = "../images/Biscôme_avec_glaçage.jpg",
                prix = 7.05,
                Langue = new List<Langues> { anglaisb1, francaisb1 }
            };
            boulangerie b2 = new boulangerie
            {
                id = 2,
                image = "../images/Bûche_de_Noël.jpg",
                prix = 32.05,
                Langue = new List<Langues> { anglaisb2, francaisb2 }

            };
            boulangerie b3 = new boulangerie
            {
                id = 3,
                image = "../images/Gâteau_Chanteclair.jpg",
                prix = 32.05,
                Langue = new List<Langues> { anglaisb3, francaisb3 }

            };
            boulangerie b4 = new boulangerie
            {
                id = 4,
                image = "../images/Chocolate_angel_food_cake_with_various_toppings.jpg",
                prix = 32.05,
                Langue = new List<Langues> { anglaisb4, francaisb4 }

            };
            boulangerie b5 = new boulangerie
            {
                id = 5,
                image = "../images/Charlotte_aux_framboises_-_Flickr_-_Ronald_van_der_Graaf.jpg",
                prix = 32.05,
                Langue = new List<Langues> { anglaisb5, francaisb5 }

            };
            boulangerie b6 = new boulangerie
            {
                id = 6,
                image = "../images/Cassata_siciliana.jpg",
                prix = 32.05,
                Langue = new List<Langues> { anglaisb6, francaisb6 }

            };


            viandes v1 = new viandes
            {
                id = 1,
                image = "../images/viande1.jpg",
                prix = 17.05,
                Langue = new List<Langues> { anglaisv1, francaisv1 }
            };
            viandes v2 = new viandes
            {
                id = 2,
                image = "../images/viande2.jpg",
                prix = 26.15,
                Langue = new List<Langues> { anglaisv2, francaisv2 }

            };
            viandes v3 = new viandes
            {
                id = 3,
                image = "../images/agneau.jpg",
                prix = 26.15,
                Langue = new List<Langues> { anglaisv3, francaisv3 }

            };
            viandes v4 = new viandes
            {
                id = 4,
                image = "../images/beef.jpg",
                prix = 26.15,
                Langue = new List<Langues> { anglaisv4, francaisv4 }

            };
            viandes v5 = new viandes
            {
                id = 5,
                image = "../images/haché.jpg",
                prix = 26.15,
                Langue = new List<Langues> { anglaisv5, francaisv5 }

            };
            viandes v6 = new viandes
            {
                id = 6,
                image = "../images/salami.jpg",
                prix = 26.15,
                Langue = new List<Langues> { anglaisv6, francaisv6 }

            };
            viandes v7 = new viandes
            {
                id = 7,
                image = "../images/saucisson.jpg",
                prix = 26.15,
                Langue = new List<Langues> { anglaisv7, francaisv7 }

            };


            fruits_et_légumes fl1 = new fruits_et_légumes
            {
                id = 1,
                image = "../images/banane.jpg",
                prix = 14.73,
                Langue = new List<Langues> { anglaisfl1, francaisfl1 }
            };
            fruits_et_légumes fl2 = new fruits_et_légumes
            {
                id = 2,
                image = "../images/fraise.jpg",
                prix = 3.48,
                Langue = new List<Langues> { anglaisfl2, francaisfl2 }

            };
            fruits_et_légumes fl3 = new fruits_et_légumes
            {
                id = 3,
                image = "../images/carotte.jpg",
                prix = 3.48,
                Langue = new List<Langues> { anglaisfl3, francaisfl3 }

            };
            fruits_et_légumes fl4 = new fruits_et_légumes
            {
                id = 4,
                image = "../images/poivrons.jpg",
                prix = 3.48,
                Langue = new List<Langues> { anglaisfl4, francaisfl4 }

            };
            fruits_et_légumes fl5 = new fruits_et_légumes
            {
                id = 5,
                image = "../images/kiwi.jpg",
                prix = 3.48,
                Langue = new List<Langues> { anglaisfl5, francaisfl5 }

            };
            fruits_et_légumes fl6 = new fruits_et_légumes
            {
                id = 6,
                image = "../images/ognions.jpg",
                prix = 3.48,
                Langue = new List<Langues> { anglaisfl6, francaisfl6 }

            };
            fruits_et_légumes fl7 = new fruits_et_légumes
            {
                id = 7,
                image = "../images/carotte.jpg",
                prix = 3.48,
                Langue = new List<Langues> { anglaisfl7, francaisfl7 }

            };
            fruits_et_légumes fl8 = new fruits_et_légumes
            {
                id = 8,
                image = "../images/fraise.jpg",
                prix = 3.48,
                Langue = new List<Langues> { anglaisfl8, francaisfl8 }

            };

            db.laitiers.Add(l1);
            db.laitiers.Add(l2);
            db.laitiers.Add(l3);
            db.laitiers.Add(l4);
            db.laitiers.Add(l5);
            db.laitiers.Add(l6);
            db.laitiers.Add(l7);
            db.laitiers.Add(l8);


            db.boulangerie.Add(b1);
            db.boulangerie.Add(b2);
            db.boulangerie.Add(b3);
            db.boulangerie.Add(b4);
            db.boulangerie.Add(b5);
            db.boulangerie.Add(b6);

            db.viandes.Add(v1);
            db.viandes.Add(v2);
            db.viandes.Add(v3);
            db.viandes.Add(v4);
            db.viandes.Add(v5);
            db.viandes.Add(v6);
            db.viandes.Add(v7);

            db.fruits_et_légumes.Add(fl1);
            db.fruits_et_légumes.Add(fl2);
            db.fruits_et_légumes.Add(fl3);
            db.fruits_et_légumes.Add(fl4);
            db.fruits_et_légumes.Add(fl4);
            db.fruits_et_légumes.Add(fl5);
            db.fruits_et_légumes.Add(fl6);
            db.fruits_et_légumes.Add(fl7);
            db.fruits_et_légumes.Add(fl8);


            db.SaveChanges();
            return View();
        }


        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string Id, string Username, string Password)
        {
            DbEpicerier db = new DbEpicerier();
            foreach (var us in db.user)
            {
                if(us.username== Username && us.password== Password)
                {
                    if(us.titre==1)
                    {
                        return RedirectToAction("AcceuilAdmin", new { titre = 1 });
                    }
                    else if(us.titre==0)
                    {
                        return RedirectToAction("Acceuil", new { titre = 0 });
                    }
                    else
                    {
                        ViewBag.msg = "Nom d'utilisateur ou mot de passe incorrect.";
                    }
                }
            }
            return View();

        }

        public ActionResult Inscription()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Inscription(string Username, string Password)
        {
            DbEpicerier db = new DbEpicerier();

                if (db.user.Any(u => u.username == Username))
                {
                    ViewBag.msg = "User already registered.";
                    return View(); 
                }

                user newUser = new user
                {
                    username = Username,
                    password = Password,
                    titre = 0 
                };
                db.user.Add(newUser);
                db.SaveChanges();

                return RedirectToAction("Login");
        }


        public ActionResult Ajouterpanier()
        {
            return RedirectToAction("Laitiers"); 
        }

        [HttpPost]
        public ActionResult Ajouterpanier(int id)
        {
            DbEpicerier db = new DbEpicerier();

            var produit = db.laitiers.FirstOrDefault(pd => pd.id == id);
            if (produit != null)
            {
                var produitPanier = new produitpanier
                {
                    image = produit.image,
                    prix = produit.prix
                };

                db.produitpanier.Add(produitPanier);
                db.SaveChanges();

            }
            int nombreTotalProduits = db.produitpanier.Count();

            return RedirectToAction("Laitiers", new { count = nombreTotalProduits });
        }
        public ActionResult payer()
        {
            return View("Payer");
        }

        public ActionResult AjouterLangue()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AjouterLangue(string Username, string Password)
        {
            DbEpicerier db = new DbEpicerier();

            if (db.user.Any(u => u.username == Username))
            {
                ViewBag.msg = "User already registered.";
                return View();
            }

            user newUser = new user
            {
                username = Username,
                password = Password,
                titre = 0
            };
            db.user.Add(newUser);
            db.SaveChanges();

            return RedirectToAction("Login");
        }
        public ActionResult ModifierUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ModifierUser(int Id, string Username, string Password)
        {
            DbEpicerier db = new DbEpicerier();

            if (db.user.Any(u => u.id == Id))
            {
                db.user.Any(u=> u.username == Username);
                db.user.Any(u => u.password == Password);
            }
                else
                {
                    ViewBag.msg = "Id incorrect.";
                }
            return View();
        }

        public ActionResult Acceuil(int titre)
        {
            DbEpicerier db = new DbEpicerier();
            ViewBag.laitier = "Produits Laitiers";
            ViewBag.boulangerie = "Produits Boulangerie";
            ViewBag.viande = "Produits Viandes";
            ViewBag.fruit_legume = "Produits Fruits et Légumes";
            ViewBag.p1 = "Bienvenue dans le system de gestion de L'inventaire des materiels";
            ViewBag.p2 = "Veuillez choisir une categorie si dessus...";
            ViewBag.titre = titre;
            return View();
        }

        [HttpPost]
        public ActionResult Acceuil()
        {
            return View("Acceuil");
        }

        public ActionResult AcceuilAdmin(int titre)
        {
            DbEpicerier db = new DbEpicerier();
            ViewBag.laitier = "Produits Laitiers";
            ViewBag.boulangerie = "Produits Boulangerie";
            ViewBag.viande = "Produits Viandes";
            ViewBag.fruit_legume = "Produits Fruits et Légumes";
            ViewBag.commande = "Voir les Commandes";
            ViewBag.ajoutlang = "Ajouter une Nouvelle Langue";
            ViewBag.modifuser = "Modifier/Supprimer un utilisateurs";
            ViewBag.p2 = "Veuillez choisir une categorie si dessus...";
            ViewBag.p1 = "Bienvenue dans le system de gestion de L'inventaire des materiels";
            ViewBag.p2 = "Veuillez choisir une categorie si dessus...";
            ViewBag.titre = titre;
            return View();
        }

        [HttpPost]
        public ActionResult AcceuilAdmin()
        {
            return View("AcceuilAdmin");
        }

        public ActionResult translateAnglais(int titre)
        {
            DbEpicerier db = new DbEpicerier();
            ViewBag.laitier = "Dairy Products";
            ViewBag.boulangerie = "Bakery Products";
            ViewBag.viande = "Meat Products";
            ViewBag.fruit_legume = "Fruit and Vegetable Products";
            ViewBag.commande = "See Commandes";
            ViewBag.ajoutlang = "Add new Language";
            ViewBag.modifuser = "Add/delete a user";
            ViewBag.p1 = "Welcome to the Material Inventory Management System";
            ViewBag.p2 = "Please choose a category if above...";
            ViewBag.Langue = "EN";
            if (titre ==1)
            {
                return View("AcceuilAdmin");
            }
            else
            {
                return View("Acceuil");
            }
            
        }
        [HttpPost]

        public ActionResult translateAnglais(string id)
        {
            return View("Acceuil");
        }

        public ActionResult translateFrancais(int titre)
        {
            DbEpicerier db = new DbEpicerier();
            ViewBag.laitier = "Produits Laitiers";
            ViewBag.boulangerie = "Produits Boulangerie";
            ViewBag.viande = "Produits Viandes";
            ViewBag.fruit_legume = "Produits Fruits et Légumes";
            ViewBag.commande = "Voir les Commandes";
            ViewBag.ajoutlang = "Ajouter une Nouvelle Langue";
            ViewBag.modifuser = "Modifier/Supprimer un utilisateurs";
            ViewBag.p1 = "Bienvenue dans le system de gestion de L'inventaire des materiels";
            ViewBag.p2 = "Veuillez choisir une categorie si dessus...";
            ViewBag.Langue = "FR";
            if (titre == 1)
            {
                return View("AcceuilAdmin");
            }
            else
            {
                return View("Acceuil");
            }
        }
        [HttpPost]

        public ActionResult translateFrancais(string id)
        {
            return View("Acceuil");
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

        public ActionResult Boulangerie(string Langue)
        {

            DbEpicerier db = new DbEpicerier();
            ViewBag.msgepi = db.boulangerie;
            ViewBag.langue = Langue;
            return View(db.laitiers);
        }
        [HttpPost]

        public ActionResult Boulangerie()
        {
            return View(new boulangerie { });
        }

        public ActionResult Viandes(string Langue)
        {
            DbEpicerier db = new DbEpicerier();
            ViewBag.msgepi = db.viandes;
            ViewBag.langue = Langue;
            return View(db.laitiers);
        }
        [HttpPost]
        public ActionResult Viandes()
        {
            return View(new viandes { });
        }
        public ActionResult Fruits_et_Légumes(string Langue)
        {
            DbEpicerier db = new DbEpicerier();
            ViewBag.msgepi = db.fruits_et_légumes;
            ViewBag.langue = Langue;
            return View(db.laitiers);
        }
        [HttpPost]
        public ActionResult Fruits_et_Légumes()
        {
            return View(new fruits_et_légumes { });
        }

    }
}