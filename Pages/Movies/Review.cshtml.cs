using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MovieReviews.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace MovieReviews.Pages.Movies
{
    public class ReviewModel : PageModel
    {
        private readonly MovieReviews.Models.MovieDbContext _context;
        private readonly ILogger _logger;

        // The Review to add. User will input a Review Score and hit submit, so we bind this property
        [BindProperty]
        public Review Review { get; set; }

        // Drop down SelectList of Movies
        public SelectList Movies {get; set;}

        public ReviewModel(MovieReviews.Models.MovieDbContext context, ILogger<ReviewModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult OnGet(int? id)
        {
            // Get a list of movies.
            Movies = new SelectList(_context.Movie.ToList(), "ID", "Title", id);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            _logger.LogInformation($"Add Review OnPost called. Review.Score = '{Review.Score}'");
            _logger.LogWarning($"Movie Id = '{Review.MovieId}'");

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Review.Add(Review); // Add review to database
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}