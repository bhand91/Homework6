using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MovieReviews.Models;

namespace MovieReviews.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovieContext _context;

        public IndexModel(RazorPagesMovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public string NameSort {get; set;}
        public string DateSort {get; set;}
        public string CurrentFilter{get; set;}

        public string CurrentSort{get; set;}

        public int PageNum {get; set;} = 1;

        public int PageSize {get; set;} = 10;

        /* public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();

            //skip((PageNum - 1)*PageSize).Take(PageSize).ToListAs();
        }
*/
        public async Task OnGetAsync(string sortOrder)
        {
            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "" ;
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";

            IQueryable<Movie> movieSort = from m in _context.Movie
                                        select m;
            switch (sortOrder)
            {
                case "name_desc":
                    movieSort = movieSort.OrderByDescending(m => m.Title);
                    break;
                case "Date":
                    movieSort = movieSort.OrderBy(m => m.ReleaseDate);
                    break;
                case "date_desc":
                    movieSort = movieSort.OrderByDescending(m => m.ReleaseDate);
                    break;
                default:
                    movieSort = movieSort.OrderBy(m => m.Title);
                    break;
            }

            Movie = await movieSort.AsNoTracking().ToListAsync();
        }
    }
}
