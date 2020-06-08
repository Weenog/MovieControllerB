using System;

namespace MovieWeb.Controllers
{
    public class MovieCreateViewModel
    {
        public string Title { get; internal set; }
        public DateTime ReleaseDate { get; internal set; }
        public string Description { get; internal set; }
        public string Genre { get; internal set; }
    }
}