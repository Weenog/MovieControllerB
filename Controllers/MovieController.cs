using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor.Compilation;
using MovieControllerB.Domain;
using MovieWeb.Database;
using MovieWeb.Models;

namespace MovieWeb.Controllers
{

    //[Route("Movie")]
    //[Route("Privacy")]
    //[Route("Important")]
    public class MovieController : Controller
    {



        private readonly IMovieDatabase _movieDatabase;
        public MovieController(IMovieDatabase movies)
        {
            _movieDatabase = movies;
        }

        //[Route("")]
        //[Route("Index")]

        public IActionResult Index(int ID)
        {
            IEnumerable<Movie> moviesFromDb = _movieDatabase.GetMovies();
            List<MovieListViewModel> movies = new List<MovieListViewModel>();
            foreach (Movie movie in moviesFromDb)
            {
                movies.Add(new MovieListViewModel() { Id = movie.ID, Title = movie.Title });
            }
            return View(movies);
        }
        public IActionResult Detail(int id)
        {
            Movie movieFromDb = _movieDatabase.GetMovie(id);
            MovieDetailViewModel movie = new MovieDetailViewModel()
            {
                Title = movieFromDb.Title,
                Description = movieFromDb.Description,
                ReleaseDate = movieFromDb.ReleaseDate,
                Genre = movieFromDb.Genre
            };
            return View(movie);
        }



        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(MovieCreateViewModel NewMovie)
        {

            if (ModelState.IsValid) 
            {
                _movieDatabase.Insert(new Movie
                {
                    Title = NewMovie.Title,
                    Description = NewMovie.Description,
                    Genre = NewMovie.Genre,
                    ReleaseDate = NewMovie.ReleaseDate
                });

                return RedirectToAction("Index");
                
            }
            return View(NewMovie);
        } 
    }
}
    


