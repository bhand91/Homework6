using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MovieReviews.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MovieReviews.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly MovieReviews.Models.MovieDbContext _context;

        public IndexModel(MovieReviews.Models.MovieDbContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }
        
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList Genres { get; set; }
        [BindProperty(SupportsGet = true)]
        public string MovieGenre { get; set; }

        public async Task OnGetAsync()
        {
            // Use LINQ to get list of genres.
            IQueryable<string> genreQuery = from m in _context.Movie
                                            orderby m.Genre
                                            select m.Genre;

            //var movies = from m in _context.Movie
            //            select m;
            // var movies = _context.Movie.Include(m => m.Reviews).Select(m => new {
            //     ID = m.ID,
            //     Title = m.Title,
            //     ReleaseDate = m.ReleaseDate,
            //     Genre = m.Genre,
            //     Price = m.Price,
            //     Rating = m.Rating,
            //     Review = m.Reviews.Average(r => r.Score)            
            // });
            // IQueryable<Movie> movies = _context.Movie.Include(m => m.Reviews);
            // var movies = (from m in _context.Movie
            //     select m).Include("Reviews");
            
            // Use .Include() to bring in the reviews
            var movies = _context.Movie.Include(m => m.Reviews).Select(m => m);

            if (!string.IsNullOrEmpty(SearchString))
            {
                movies = movies.Where(s => s.Title.Contains(SearchString));
            }
            
            if (!string.IsNullOrEmpty(MovieGenre))
            {
                movies = movies.Where(x => x.Genre == MovieGenre);
            }

            Genres = new SelectList(await genreQuery.Distinct().ToListAsync());
            Movie = await movies.ToListAsync();
        }
    }
}
