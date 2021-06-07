using PhonebookMVC.Models;
using PhonebookMVC.Repositories;
using PhonebookMVC.Services;
using PhonebookMVC.ViewModels.Publications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhonebookMVC.Controllers
{
    public class PublicationsController : Controller
    {
        public ActionResult Index()
        {
            PublicationsListVM model = new PublicationsListVM();

            TryUpdateModel(model);

            PublicationRepository groupRepo = new PublicationRepository();

            model.Entities = groupRepo.GetAll(g => g.UserID == AuthenticationService.LoggedUser.ID);

            return View(model);
        }

        public ActionResult Details(int? id)
        {
            if (id != null)
            {
                PublicationRepository groupRepo = new PublicationRepository();

                Publication group = groupRepo.GetById(id.Value);

                if (group != null && group.UserID == AuthenticationService.LoggedUser.ID)
                {
                    EventsCreateEditVM g = new EventsCreateEditVM()
                    {
                        ID = group.ID,
                        Titre = group.Titre,
                        Context = group.Context,
                        UserID = group.UserID
                    };

                    return View(g);
                }
            }

            return RedirectToAction("Index");
        }

        public ActionResult CreateEdit(int? id)
        {
            if (id == null) // Create
            {
                return View(new EventsCreateEditVM()
                {
                    UserID = AuthenticationService.LoggedUser.ID
                });
            }

            else if (id > 0) // Edit
            {
                PublicationRepository groupRepo = new PublicationRepository();

                Publication group = groupRepo.GetById(id.Value);

                if (group != null && group.UserID == AuthenticationService.LoggedUser.ID)
                {
                    EventsCreateEditVM g = new EventsCreateEditVM()
                    {
                        ID = group.ID,
                        Titre = group.Titre,
                        Context = group.Context,
                        UserID = group.UserID
                    };

                    return View(g);
                }
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateEdit(EventsCreateEditVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            Publication group;

            PublicationRepository groupRepo = new PublicationRepository();

            if (model.ID > 0) // Edit
            {
                group = groupRepo.GetById(model.ID);

                if (group == null || group.UserID != model.UserID)
                {
                    return HttpNotFound();
                }
            }

            else // Create
            {
                group = new Publication()
                {
                    UserID = AuthenticationService.LoggedUser.ID
                };
            }

            if (group.UserID == AuthenticationService.LoggedUser.ID)
            {
                
                group.Titre = model.Titre;
                group.Context = model.Context;


                /*
                        Titre = group.Titre,
                        Context = group.Context,
                        ImagePub = group.ImagePub,
                 */

                groupRepo.Save(group);

                return RedirectToAction("Index");
            }

            return HttpNotFound();
        }

        public ActionResult Delete(int? id)
        {
            if (id != null)
            {
                PublicationRepository groupRepo = new PublicationRepository();

                Publication group = groupRepo.GetById(id.Value);

                if (group != null && group.UserID == AuthenticationService.LoggedUser.ID)
                {
                    EventsCreateEditVM g = new EventsCreateEditVM()
                    {
                        ID = group.ID,
                        Titre = group.Titre,
                        Context = group.Context
                    };

                    return View(g);
                }
            }

            return RedirectToAction("Index");
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int? id)
        {
            if (id != null)
            {
                PublicationRepository groupRepo = new PublicationRepository();

                Publication group = groupRepo.GetById(id.Value);

                if (group != null && group.UserID == AuthenticationService.LoggedUser.ID)
                {
                    
                    groupRepo.Delete(group);

                    return RedirectToAction("Index");
                }
            }

            return HttpNotFound();
        }
    


    }
}