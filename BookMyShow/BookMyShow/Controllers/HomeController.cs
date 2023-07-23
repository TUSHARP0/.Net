using BookMyShow.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Collections.Generic;
using BOL;
using BLL;
using DAL;

namespace BookMyShow.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Movies()
        {
            List<Movie> list= ShowManager.getMovies();
            ViewBag.ListOfMovies= list;
            return View();
        }

        [HttpPost]
        public IActionResult Add(string movieId, string movieName,string actorName,string ticketPrice,string releaseDate) 
            
        {
            Movie movie = new Movie(int.Parse(movieId), movieName, actorName, double.Parse(ticketPrice), DateOnly.FromDateTime(DateTime.Parse(releaseDate)));
            ShowManager.Insert(movie);
            return RedirectToAction("Movies");
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Remove(int movieId)
        {
            ShowManager.Delete(movieId);
            return RedirectToAction("Movies");
        }

        public IActionResult Remove()
        {
            return View();
        }

        public IActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Update(string movieId,string movieName,string actorName,string ticketPrice,string releaseDate) 
        {
            Movie movie = new Movie(int.Parse(movieId), movieName, actorName, double.Parse(ticketPrice), DateOnly.FromDateTime(DateTime.Parse(releaseDate)));
            ShowManager.Edit(movie);
            return RedirectToAction("Movies");
        }
 
        public IActionResult GetById(int id)
        {
           Movie movie= ShowManager.getById(id);
            if(movie != null)
            {
                ViewBag.GETMOVIE = movie;
                return View();
            }
            return RedirectToAction("Index");

        } 
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}