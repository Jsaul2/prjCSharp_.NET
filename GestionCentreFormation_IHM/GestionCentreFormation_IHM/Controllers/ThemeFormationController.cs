using GestionCentreFormation_Metier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace GestionCentreFormation_IHM.Controllers
{
    public class ThemeFormationController : Controller
    {
        // GET: ThemeFormation
        public ActionResult Index()
        {
            // Variable locales
            FormationEntities oContexteDonnees;

            /**********************************************************************/
            /*                          Bloc d'instruction                         /
            /**********************************************************************/

            // Initialisation
            oContexteDonnees = new FormationEntities();

            // retour | Affichage de la liste de themes
            return View(new FormationEntities().Theme);
            /**********************************************************************/

        }

        public ActionResult Create()
        {
            // Variable locales
            Theme oTheme;

            // Initialisation
            oTheme = new Theme();

            // retour |
            return View(oTheme);
        }

        public ActionResult Add(Theme aTheme)
        {
            // Variable locales
            FormationEntities oContexteDonnees;

            // Initialisation
            oContexteDonnees = new FormationEntities();

            // Ajout du theme
            oContexteDonnees.Theme.Add(aTheme);
            oContexteDonnees.SaveChanges();

            // retour | Affichage de la liste de themes
            return RedirectToAction("Index");
        }

        public ActionResult Details(int? id)
        {
            // Variable locales
            ActionResult oActionResult;
            FormationEntities oContexteDonnees;
            Theme oTheme;

            // Verification de l'ID
            if (!id.HasValue)
            {// Si non, affichage du méssage d'erreur
                oActionResult = new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                // Initialisation
                oContexteDonnees = new FormationEntities();

                // Récupération du theme = l'id passé en paramètre
                oTheme = (from oT in oContexteDonnees.Theme where oT.Identifiant == id.Value select oT).FirstOrDefault();

                // Verification de la présence du theme
                if (oTheme == null)
                {// Si le theme n'existe pas, affichage du méssage d'erreur
                    oActionResult = new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                else
                {
                    // Initialisation de oActionResult avec le theme
                    oActionResult = View(oTheme);
                }
            }

            // retour | Affichage du theme
            return oActionResult;
        }

        public ActionResult Edit(int? id)
        {
            // Variable locales
            ActionResult oActionResult;
            FormationEntities oContexteDonnees;
            Theme oTheme;

            if (!id.HasValue)
            {// Si non, affichage du méssage d'erreur
                oActionResult = new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                // Initialisation
                oContexteDonnees = new FormationEntities();

                // Récupération du theme = l'id passé en paramètre
                oTheme = (from oT in oContexteDonnees.Theme
                          where oT.Identifiant == id.Value
                          select oT).FirstOrDefault();

                // Verification de la présence du theme
                if (oTheme == null)
                {// Si le theme n'existe pas, affichage du méssage d'erreur
                    oActionResult = new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                else
                {
                    // Initialisation de oActionResult avec le theme
                    oActionResult = View(oTheme);
                }
            }

            // retour |
            return oActionResult;
        }

        public ActionResult Update(Theme aTheme)
        {
            // Variable locales
            ActionResult oActionResult;
            FormationEntities oContexteDonnees;
            Theme oTheme;

            // Initialisation
            oContexteDonnees = new FormationEntities();

            // Récupération du theme = l'id passé en paramètre
            oTheme = (from oT in oContexteDonnees.Theme
                      where oT.Identifiant == aTheme.Identifiant
                      select oT).FirstOrDefault();

            // Verification de la présence du theme
            if (oTheme == null)
            {// Si le theme n'existe pas, affichage du méssage d'erreur
                oActionResult = new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                // Modification du Libelle du theme & sauvegarde de la MAJ bdd
                oTheme.Libelle = aTheme.Libelle;
                oContexteDonnees.SaveChanges();

                // Initialisation de oActionResult avec le theme
                oActionResult = RedirectToAction("Index");    
            }

            // retour | Affichage de la liste de themes
            return oActionResult;
        }

        public ActionResult Delete(int? id)
        {
            // Variable locales
            ActionResult oActionResult;
            FormationEntities oContexteDonnees;
            Theme oTheme;

            // Verification de l'ID
            if (!id.HasValue)
            {
                oActionResult = new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                // Initialisation
                oContexteDonnees = new FormationEntities();

                // Récupération du theme = l'id passé en paramètre
                oTheme = (from oT in oContexteDonnees.Theme
                          where oT.Identifiant == id.Value
                          select oT).FirstOrDefault();

                // Verification de la présence du theme
                if (oTheme == null)
                {
                    oActionResult = new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                else
                {
                    // Suppression du theme & sauvegarde de la MAJ bdd
                    oContexteDonnees.Theme.Remove(oTheme);
                    oContexteDonnees.SaveChanges();

                    // Initialisation de oActionResult avec le theme
                    oActionResult = RedirectToAction("Index");
                }
            }

            // retour | Affichage du theme
            return oActionResult;
        }
    }
}