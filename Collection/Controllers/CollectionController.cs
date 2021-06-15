using Collection.Data;
using Collection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Collection.Controllers
{
    public class CollectionController : Controller
    {
        // GET: Collection
        public ActionResult Index()
        {
            List<CollectionModel> collections = new List<CollectionModel>();

            CollectionTableDAO collectionTableDAO = new CollectionTableDAO();

            collections = collectionTableDAO.FetchAll();

            return View("Index", collections);

        }

        public ActionResult Details(int id)
        {
            CollectionTableDAO CollectionTableDAO = new CollectionTableDAO();

            CollectionModel collection = CollectionTableDAO.FetchOne(id);


            return View("Details", collection);
        }

        public ActionResult Create()
        {
            return View("CollectionForm");
        }
        public ActionResult Edit(int id)
        {
            CollectionTableDAO CollectionTableDAO = new CollectionTableDAO();
            CollectionModel collection = CollectionTableDAO.FetchOne(id);

            return View("CollectionForm", collection);
        }
        public ActionResult Delete(int id)
        {
            CollectionTableDAO CollectionTableDAO = new CollectionTableDAO();
            CollectionTableDAO.Delete(id);

            List<CollectionModel> collections = CollectionTableDAO.FetchAll();

            return View("Index", collections);
        }

        public ActionResult ProcessCreate(CollectionModel collectionModel)
        {
            // save to db.
            CollectionTableDAO collectionTableDAO = new CollectionTableDAO();

            collectionTableDAO.CreateOrUpdate(collectionModel);

            return View("Details", collectionModel);
        }

        public ActionResult SearchForm()
        {
            return  View("SearchForm");
        }

        public ActionResult SearchForName(string searchPhrase)
        {

            //get a list of search results from the database

            CollectionTableDAO collectionTableDAO= new CollectionTableDAO();
            List<CollectionModel> searchResults = collectionTableDAO.SearchForName(searchPhrase);


            return View("Index", searchResults);
        }
    }
}