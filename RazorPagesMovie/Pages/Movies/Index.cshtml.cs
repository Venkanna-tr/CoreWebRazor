using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages.Movies {
    public class IndexModel : PageModel {
        private readonly RazorPagesMovie.Models.MovieContext _context;

        public IndexModel (MovieContext context) {
            _context = context;
        }

        public IList<Movie> Movie { get; set; }
        public string SearchString { get; set; }
        public SelectList Genres { get; set; }
        public string MovieGenre { get; set; }

        public async Task OnGetAsync (string searchString) {
            var movies = from m in _context.Movie
            select m;

            if (!string.IsNullOrEmpty (searchString)) {
                movies = movies.Where (x => x.Title.Contains (searchString));
            }
            Movie = await movies.ToListAsync ();
            SearchString = searchString;
        }
    }
}