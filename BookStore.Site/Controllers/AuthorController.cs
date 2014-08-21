using BookStore.BLL;
using BookStore.BusinessObjects;
using Michael.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Michael.Controllers
{
    public class AuthorController : Controller
    {
        //
        // GET: /Author/
        public ActionResult Index()
        {
            AuthorBusinessService service = new AuthorBusinessService();
            List<Author> authors = service.GetAuthors();

            List<AuthorViewModel> models = new List<AuthorViewModel>();

            foreach (Author author in authors)
            { 
                AuthorViewModel model = new AuthorViewModel();
                model.Id = author.Id;
                model.FirstName = author.FirstName;
                model.LastName = author.LastName;

                models.Add(model);
            }

            return View(models);
        }
         

        //
        // GET: /Author/Create
        public ActionResult Create()
        {

            return View();
        }

        //
        // POST: /Author/Create
        [HttpPost]
        public ActionResult Create(AuthorViewModel model)
        {
            try
            {
                // TODO: Add insert logic here

                Author author = new Author();
                author.Id = model.Id;
                author.FirstName = model.FirstName;
                author.LastName = model.LastName;


                AuthorBusinessService service = new AuthorBusinessService();
                service.SaveAuthor(author);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Author/Edit/5
        public ActionResult Edit(int id)
        {
            Author author = new AuthorBusinessService().GetAuthorById(id);
            AuthorViewModel model = new AuthorViewModel();
            model.Id = author.Id;
            model.FirstName = author.FirstName;
            model.LastName = author.LastName;

            return View(model);
        }
 
        // POST: /Author/Delete/5
       // [HttpPost]
        public ActionResult Delete(int id)
        { 
                new AuthorBusinessService().Delete(id);

                return RedirectToAction("Index"); 
        }
    }
}
