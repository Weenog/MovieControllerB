using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor.Compilation;
using MovieWeb.Domain;
using MovieWeb.Database;
using MovieWeb.Models;

namespace MovieWeb.Controllers
{

    public class MovieController : Controller
    {
        private readonly IMovieDatabase _movieDatabase;
        private object movieFromDb;

        public object Id { get; private set; }
        public object Title { get; private set; }

        public MovieController(IMovieDatabase movies)
        {
            _movieDatabase = movies;
        }

        //[Route("")]
        //[Route("Index")]

        public IActionResult Index(int Id)
        {
            IEnumerable<Movie> moviesFromDb = _movieDatabase.GetMovies();
            List<MovieListViewModel> movies = new List<MovieListViewModel>();
            foreach (Movie movie in moviesFromDb)
            {
                movies.Add(new MovieListViewModel() { Id = movie.Id, Title = movie.Title });
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
            MovieCreateViewModel vm = new MovieCreateViewModel()
            {
                ReleaseDate = DateTime.Now
            };

            return View(vm);
        }


        [HttpPost]


        public IActionResult Create(MovieCreateViewModel NewMovie)
        {
            if (!TryValidateModel(NewMovie))
            {

                return View(NewMovie);

            }

            _movieDatabase.Insert(new Movie

            {

                Title = NewMovie.Title,

                Description = NewMovie.Description,

                Genre = NewMovie.Genre,

                ReleaseDate = NewMovie.ReleaseDate

            });

            return RedirectToAction("index");

        }

        public IActionResult Edit(int id)
        {
            Movie movieFromDb = _movieDatabase.GetMovie(id);
            MovieEditViewModel viewModel = new MovieEditViewModel()
            {
                Title = movieFromDb.Title,
                Description = movieFromDb.Description,
                ReleaseDate = movieFromDb.ReleaseDate,
                Genre = movieFromDb.Genre
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Edit(int id, MovieEditViewModel ViewModel)
        {

            Movie movie = new Movie()
            {
                Title = ViewModel.Title,
                Description = ViewModel.Description,
                ReleaseDate = ViewModel.ReleaseDate,
                Genre = ViewModel.Genre
            };

            _movieDatabase.Update(id, movie);
            return RedirectToAction("Detail", new { Id = id });
        }

        public IActionResult Delete(int id)
        {
            Movie movieFromDB = _movieDatabase.GetMovie(id);


            MovieDeleteViewModel movie = new MovieDeleteViewModel()
            {
                Id = id,

                Title = movieFromDB.Title
            };

            return View(movie);
        }
        [HttpPost]
        public IActionResult ConfirmDelete(int id)

        {

            _movieDatabase.Delete(id);
            return RedirectToAction("Index");

        }

    }

}

