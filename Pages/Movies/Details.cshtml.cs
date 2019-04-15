using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MovieReviews.Models;
using Microsoft.Extensions.Logging;

namespace MovieReviews.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly MovieReviews.Models.MovieDbContext _context;
        private readonly ILogger _logger;

        public DetailsModel(MovieReviews.Models.MovieDbContext context, ILogger<ReviewModel> logger)
        {
            _logger = logger;
            _context = context;
        }

        public Movie Movie { get; set; }

        // Extra Credit Version 1: In Details.cshtml.cs, pick a review to delete.
        [BindProperty]
        public int ReviewIdToDelete {get; set;}

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // Pull in all the reviews with .Include(). The .cshtml Razor Page can now display them
            Movie = await _context.Movie.Include(m => m.Reviews).FirstOrDefaultAsync(m => m.ID == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }

        public void OnPost(int? id)
        {
            _logger.LogWarning($"OnPost() called. Movie Id {id}");

        }

        // Extra Credit Version 1: When user clicks Delete Review button. This is what executes
        // async Task<IActionResult> ==> Asynchronous
        // IActionResult ==> Syncronous
        public IActionResult OnPostDeleteReviewAsync(int? id)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogWarning($"OnPostDeleteReview() invalid model.");
                return Page();
            }
            _logger.LogWarning($"OnPostDeleteReview() called. Movie Id {id}. Review Id {ReviewIdToDelete}");

            // Find the review in the database
            Review Review = _context.Review.FirstOrDefault(r => r.ID == ReviewIdToDelete);

            if (Review != null)
            {
                _context.Remove(Review); // Delete the review
                _context.SaveChanges();
            }
            Movie = _context.Movie.Include(m => m.Reviews).FirstOrDefault(m => m.ID == id);

            return Page();            
        }
    }
}
