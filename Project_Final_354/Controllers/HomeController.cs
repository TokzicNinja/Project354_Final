using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Dynamic;
using Project_Final_354.Models;

namespace Project_Final_354.Controllers
{
    public class HomeController : Controller
    {

        private ProjectDBEntities db = new ProjectDBEntities();
        // GET: Home
        public ActionResult Index()
        {
            //HomeModel.ViewModel myModel = new HomeModel.ViewModel();

            //dynamic model = new ExpandoObject();
            //model.Client = GetClient();
            //model.Games = GetGames();

            var model = new HomeModel();
            model.client = db.Clients.ToList();
            model.game = db.Games.ToList();
            model.gameGenre = db.GameGenres.ToList();

            return View(model);
        }

        //public List<Project_Final_354.Client>GetClient()
        //{
        //    List<Client> client = new List<Client>();
        //    return client = db.Clients.ToList();
        //}

        //public List<Project_Final_354.Game>GetGames()
        //{
        //    List<Project_Final_354.Game> games = new List<Game>();
        //    return games = db.Games.ToList();
        //}
    }
}