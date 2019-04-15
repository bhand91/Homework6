using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Collections.Generic;

namespace MovieReviews.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MovieDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MovieDbContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M,
                        Rating = "R",
                        Reviews = new List<Review> {
                            new Review {Score = 1},
                            new Review {Score = 5}
                        }
                    },

                    new Movie
                    {
                        Title = "Ghostbusters",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M,
                        Rating = "PG",
                        Reviews = new List<Review> {
                            new Review {Score = 5}
                        }
                    },

                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 3},
                            new Review {Score = 4}
                        }
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M,
                        Rating = "G",
                    },

                    
                    new Movie
                    {
                        Title = "Avatar",
                        ReleaseDate = DateTime.Parse("12/10/2009"),
                        Genre = "Adventure",
                        Price = 20.0M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 4},
                            new Review {Score = 5}
                        }
                    },

                    new Movie
                    {
                        Title = "Pirates of the Caribbean: At World's End",
                        ReleaseDate = DateTime.Parse("5/19/2007"),
                        Genre = "Fantasy",
                        Price = 5.99M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 2}
                        }
                    },

                    new Movie
                    {
                        Title = "Spectre",
                        ReleaseDate = DateTime.Parse("10/26/2015"),
                        Genre = "Thriller",
                        Price = 24.95M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 1}
                        }
                    },

                    new Movie
                    {
                        Title = "The Dark Knight Rises",
                        ReleaseDate = DateTime.Parse("7/16/2012"),
                        Genre = "Thriller",
                        Price = 24.99M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 2},
                            new Review {Score = 5},
                            new Review {Score = 2}
                        }
                    },

                    new Movie
                    {
                        Title = "Star Wars: Episode VII - The Force Awakens",
                        ReleaseDate = DateTime.Parse("7/16/2012"),
                        Genre = "Documentary",
                        Price = 6.99M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 1}
                        }
                    },

                    new Movie
                    {
                        Title = "John Carter",
                        ReleaseDate = DateTime.Parse("3/7/2012"),
                        Genre = "Action",
                        Price = 19.95M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 1}
                        }
                    },

                    new Movie
                    {
                        Title = "Spider-Man 3",
                        ReleaseDate = DateTime.Parse("5/1/2007"),
                        Genre = "Adventure",
                        Price = 26.99M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 2}
                        }
                    },

                    new Movie
                    {
                        Title = "Tangled",
                        ReleaseDate = DateTime.Parse("11/24/2010"),
                        Genre = "Family",
                        Price = 9.95M,
                        Rating = "PG",
                        Reviews = new List<Review> {
                            new Review {Score = 1},
                            new Review {Score = 3},
                            new Review {Score = 1}
                        }
                    },

                    new Movie
                    {
                        Title = "Avengers: Age of Ultron",
                        ReleaseDate = DateTime.Parse("4/22/2015"),
                        Genre = "Adventure",
                        Price = 15.99M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 1}
                        }
                    },

                    new Movie
                    {
                        Title = "Harry Potter and the Half-Blood Prince",
                        ReleaseDate = DateTime.Parse("7/7/2009"),
                        Genre = "Fantasy",
                        Price = 19.95M,
                        Rating = "PG",
                        Reviews = new List<Review> {
                            new Review {Score = 4},
                            new Review {Score = 4},
                            new Review {Score = 4}
                        }
                    },

                    new Movie
                    {
                        Title = "Batman v Superman: Dawn of Justice",
                        ReleaseDate = DateTime.Parse("3/23/2016"),
                        Genre = "Action",
                        Price = 29.99M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 5}
                        }
                    },

                    new Movie
                    {
                        Title = "Superman Returns",
                        ReleaseDate = DateTime.Parse("6/28/2006"),
                        Genre = "Action",
                        Price = 29.99M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 2}
                        }
                    },

                    new Movie
                    {
                        Title = "Quantum of Solace",
                        ReleaseDate = DateTime.Parse("10/30/2008"),
                        Genre = "Action",
                        Price = 24.95M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 5},
                            new Review {Score = 2}
                        }
                    },

                    new Movie
                    {
                        Title = "Pirates of the Caribbean: Dead Man's Chest",
                        ReleaseDate = DateTime.Parse("6/20/2006"),
                        Genre = "Adventure",
                        Price = 26.99M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 4}
                        }
                    },

                    new Movie
                    {
                        Title = "The Lone Ranger",
                        ReleaseDate = DateTime.Parse("7/3/2013"),
                        Genre = "Action",
                        Price = 22.95M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 2},
                            new Review {Score = 3}
                        }
                    },

                    new Movie
                    {
                        Title = "Man of Steel",
                        ReleaseDate = DateTime.Parse("6/12/2013"),
                        Genre = "Action",
                        Price = 26.99M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 2},
                            new Review {Score = 2},
                            new Review {Score = 5}
                        }
                    },

                    new Movie
                    {
                        Title = "The Chronicles of Narnia: Prince Caspian",
                        ReleaseDate = DateTime.Parse("5/15/2008"),
                        Genre = "Action",
                        Price = 19.99M,
                        Rating = "PG",
                        Reviews = new List<Review> {
                            new Review {Score = 1}
                        }
                    },

                    new Movie
                    {
                        Title = "The Avengers",
                        ReleaseDate = DateTime.Parse("4/25/2012"),
                        Genre = "Action",
                        Price = 19.99M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 1},
                            new Review {Score = 2},
                            new Review {Score = 1}
                        }
                    },

                    new Movie
                    {
                        Title = "Pirates of the Caribbean: On Stranger Tides",
                        ReleaseDate = DateTime.Parse("5/14/2011"),
                        Genre = "Action",
                        Price = 15.99M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 4},
                            new Review {Score = 4}
                        }
                    },

                    new Movie
                    {
                        Title = "Men in Black 3",
                        ReleaseDate = DateTime.Parse("5/23/2012"),
                        Genre = "Sci-Fi",
                        Price = 29.99M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 5},
                            new Review {Score = 3},
                            new Review {Score = 5}
                        }
                    },

                    new Movie
                    {
                        Title = "The Hobbit: The Battle of the Five Armies",
                        ReleaseDate = DateTime.Parse("12/10/2014"),
                        Genre = "Fantasy",
                        Price = 9.99M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 5}
                        }
                    },

                    new Movie
                    {
                        Title = "The Amazing Spider-Man",
                        ReleaseDate = DateTime.Parse("6/27/2012"),
                        Genre = "Action",
                        Price = 22.95M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 4},
                            new Review {Score = 5},
                            new Review {Score = 4}
                        }
                    },

                    new Movie
                    {
                        Title = "Robin Hood",
                        ReleaseDate = DateTime.Parse("5/12/2010"),
                        Genre = "Action",
                        Price = 10.99M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 5},
                            new Review {Score = 1},
                            new Review {Score = 1}
                        }
                    },

                    new Movie
                    {
                        Title = "The Hobbit: The Desolation of Smaug",
                        ReleaseDate = DateTime.Parse("12/11/2013"),
                        Genre = "Fantasy",
                        Price = 24.99M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 1}
                        }
                    },

                    new Movie
                    {
                        Title = "The Golden Compass",
                        ReleaseDate = DateTime.Parse("12/4/2007"),
                        Genre = "Fantasy",
                        Price = 9.99M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 5},
                            new Review {Score = 1},
                            new Review {Score = 1}
                        }
                    },

                    new Movie
                    {
                        Title = "King Kong",
                        ReleaseDate = DateTime.Parse("12/14/2005"),
                        Genre = "Adventure",
                        Price = 29.99M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 3}
                        }
                    },

                    new Movie
                    {
                        Title = "Titanic",
                        ReleaseDate = DateTime.Parse("11/18/1997"),
                        Genre = "Romance",
                        Price = 24.95M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 5}
                        }
                    },

                    new Movie
                    {
                        Title = "Captain America: Civil War",
                        ReleaseDate = DateTime.Parse("4/27/2016"),
                        Genre = "Sci-Fi",
                        Price = 28.99M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 3}
                        }
                    },

                    new Movie
                    {
                        Title = "Battleship",
                        ReleaseDate = DateTime.Parse("4/11/2012"),
                        Genre = "Adventure",
                        Price = 7.99M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 4}
                        }
                    },

                    new Movie
                    {
                        Title = "Jurassic World",
                        ReleaseDate = DateTime.Parse("6/9/2015"),
                        Genre = "Thriller",
                        Price = 10.99M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 2},
                            new Review {Score = 2}
                        }
                    },

                    new Movie
                    {
                        Title = "Skyfall",
                        ReleaseDate = DateTime.Parse("10/25/2012"),
                        Genre = "Action",
                        Price = 20.0M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 4},
                            new Review {Score = 1}
                        }
                    },

                    new Movie
                    {
                        Title = "Spider-Man 2",
                        ReleaseDate = DateTime.Parse("6/25/2004"),
                        Genre = "Adventure",
                        Price = 13.95M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 5},
                            new Review {Score = 5},
                            new Review {Score = 1}
                        }
                    },

                    new Movie
                    {
                        Title = "Iron Man 3",
                        ReleaseDate = DateTime.Parse("4/18/2013"),
                        Genre = "Action",
                        Price = 10.99M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 2},
                            new Review {Score = 2},
                            new Review {Score = 5}
                        }
                    },

                    new Movie
                    {
                        Title = "Alice in Wonderland",
                        ReleaseDate = DateTime.Parse("3/3/2010"),
                        Genre = "Family",
                        Price = 6.99M,
                        Rating = "PG",
                        Reviews = new List<Review> {
                            new Review {Score = 3}
                        }
                    },

                    new Movie
                    {
                        Title = "X-Men: The Last Stand",
                        ReleaseDate = DateTime.Parse("5/24/2006"),
                        Genre = "Fantasy",
                        Price = 15.99M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 4},
                            new Review {Score = 5}
                        }
                    },

                    new Movie
                    {
                        Title = "Monsters University",
                        ReleaseDate = DateTime.Parse("6/20/2013"),
                        Genre = "Animation",
                        Price = 9.99M,
                        Rating = "G",
                        Reviews = new List<Review> {
                            new Review {Score = 5},
                            new Review {Score = 3}
                        }
                    },

                    new Movie
                    {
                        Title = "Transformers: Revenge of the Fallen",
                        ReleaseDate = DateTime.Parse("6/19/2009"),
                        Genre = "Action",
                        Price = 6.99M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 4},
                            new Review {Score = 4},
                            new Review {Score = 4}
                        }
                    },

                    new Movie
                    {
                        Title = "Transformers: Age of Extinction",
                        ReleaseDate = DateTime.Parse("6/25/2014"),
                        Genre = "Sci-Fi",
                        Price = 14.99M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 5},
                            new Review {Score = 3},
                            new Review {Score = 5}
                        }
                    },

                    new Movie
                    {
                        Title = "Oz the Great and Powerful",
                        ReleaseDate = DateTime.Parse("3/7/2013"),
                        Genre = "Fantasy",
                        Price = 27.0M,
                        Rating = "PG",
                        Reviews = new List<Review> {
                            new Review {Score = 3},
                            new Review {Score = 4},
                            new Review {Score = 5}
                        }
                    },

                    new Movie
                    {
                        Title = "The Amazing Spider-Man 2",
                        ReleaseDate = DateTime.Parse("4/16/2014"),
                        Genre = "Sci-Fi",
                        Price = 27.0M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 4},
                            new Review {Score = 5}
                        }
                    },

                    new Movie
                    {
                        Title = "TRON: Legacy",
                        ReleaseDate = DateTime.Parse("12/10/2010"),
                        Genre = "Sci-Fi",
                        Price = 27.0M,
                        Rating = "PG",
                        Reviews = new List<Review> {
                            new Review {Score = 2},
                            new Review {Score = 5}
                        }
                    },

                    new Movie
                    {
                        Title = "Cars 2",
                        ReleaseDate = DateTime.Parse("6/11/2011"),
                        Genre = "Animation",
                        Price = 13.95M,
                        Rating = "G",
                        Reviews = new List<Review> {
                            new Review {Score = 5}
                        }
                    },

                    new Movie
                    {
                        Title = "Green Lantern",
                        ReleaseDate = DateTime.Parse("6/16/2011"),
                        Genre = "Adventure",
                        Price = 26.99M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 5},
                            new Review {Score = 3}
                        }
                    },

                    new Movie
                    {
                        Title = "Toy Story 3",
                        ReleaseDate = DateTime.Parse("6/16/2010"),
                        Genre = "Animation",
                        Price = 24.95M,
                        Rating = "G",
                        Reviews = new List<Review> {
                            new Review {Score = 3}
                        }
                    },

                    new Movie
                    {
                        Title = "Terminator Salvation",
                        ReleaseDate = DateTime.Parse("5/20/2009"),
                        Genre = "Action",
                        Price = 29.99M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 1},
                            new Review {Score = 1}
                        }
                    },

                    new Movie
                    {
                        Title = "Furious 7",
                        ReleaseDate = DateTime.Parse("4/1/2015"),
                        Genre = "Action",
                        Price = 8.99M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 5}
                        }
                    },

                    new Movie
                    {
                        Title = "World War Z",
                        ReleaseDate = DateTime.Parse("6/20/2013"),
                        Genre = "Adventure",
                        Price = 9.99M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 2},
                            new Review {Score = 2},
                            new Review {Score = 4}
                        }
                    },

                    new Movie
                    {
                        Title = "X-Men: Days of Future Past",
                        ReleaseDate = DateTime.Parse("5/15/2014"),
                        Genre = "Fantasy",
                        Price = 28.99M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 4}
                        }
                    },

                    new Movie
                    {
                        Title = "Star Trek Into Darkness",
                        ReleaseDate = DateTime.Parse("5/5/2013"),
                        Genre = "Adventure",
                        Price = 29.99M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 4},
                            new Review {Score = 5}
                        }
                    },

                    new Movie
                    {
                        Title = "Jack the Giant Slayer",
                        ReleaseDate = DateTime.Parse("2/27/2013"),
                        Genre = "Adventure",
                        Price = 24.95M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 2}
                        }
                    },

                    new Movie
                    {
                        Title = "The Great Gatsby",
                        ReleaseDate = DateTime.Parse("5/10/2013"),
                        Genre = "Romance",
                        Price = 9.95M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 2},
                            new Review {Score = 5},
                            new Review {Score = 4}
                        }
                    },

                    new Movie
                    {
                        Title = "Prince of Persia: The Sands of Time",
                        ReleaseDate = DateTime.Parse("5/19/2010"),
                        Genre = "Action",
                        Price = 14.99M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 4}
                        }
                    },

                    new Movie
                    {
                        Title = "Pacific Rim",
                        ReleaseDate = DateTime.Parse("7/11/2013"),
                        Genre = "Sci-Fi",
                        Price = 19.99M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 5},
                            new Review {Score = 2},
                            new Review {Score = 3}
                        }
                    },

                    new Movie
                    {
                        Title = "Transformers: Dark of the Moon",
                        ReleaseDate = DateTime.Parse("6/28/2011"),
                        Genre = "Adventure",
                        Price = 22.95M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 4}
                        }
                    },

                    new Movie
                    {
                        Title = "Indiana Jones and the Kingdom of the Crystal Skull",
                        ReleaseDate = DateTime.Parse("5/21/2008"),
                        Genre = "Action",
                        Price = 24.95M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 3}
                        }
                    },

                    new Movie
                    {
                        Title = "The Good Dinosaur",
                        ReleaseDate = DateTime.Parse("11/14/2015"),
                        Genre = "Adventure",
                        Price = 6.99M,
                        Rating = "PG",
                        Reviews = new List<Review> {
                            new Review {Score = 4},
                            new Review {Score = 3}
                        }
                    },

                    new Movie
                    {
                        Title = "Brave",
                        ReleaseDate = DateTime.Parse("6/21/2012"),
                        Genre = "Fantasy",
                        Price = 9.99M,
                        Rating = "PG",
                        Reviews = new List<Review> {
                            new Review {Score = 4},
                            new Review {Score = 4}
                        }
                    },

                    new Movie
                    {
                        Title = "Star Trek Beyond",
                        ReleaseDate = DateTime.Parse("7/7/2016"),
                        Genre = "Sci-Fi",
                        Price = 24.95M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 2},
                            new Review {Score = 3}
                        }
                    },

                    new Movie
                    {
                        Title = "WALLÂ·E",
                        ReleaseDate = DateTime.Parse("6/22/2008"),
                        Genre = "Adventure",
                        Price = 15.99M,
                        Rating = "G",
                        Reviews = new List<Review> {
                            new Review {Score = 1},
                            new Review {Score = 1}
                        }
                    },

                    new Movie
                    {
                        Title = "Rush Hour 3",
                        ReleaseDate = DateTime.Parse("8/8/2007"),
                        Genre = "Action",
                        Price = 12.95M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 2}
                        }
                    },

                    new Movie
                    {
                        Title = "2012",
                        ReleaseDate = DateTime.Parse("10/10/2009"),
                        Genre = "Action",
                        Price = 24.99M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 5},
                            new Review {Score = 1},
                            new Review {Score = 3}
                        }
                    },

                    new Movie
                    {
                        Title = "A Christmas Carol",
                        ReleaseDate = DateTime.Parse("11/4/2009"),
                        Genre = "Fantasy",
                        Price = 6.99M,
                        Rating = "PG",
                        Reviews = new List<Review> {
                            new Review {Score = 5},
                            new Review {Score = 3},
                            new Review {Score = 4}
                        }
                    },

                    new Movie
                    {
                        Title = "Jupiter Ascending",
                        ReleaseDate = DateTime.Parse("2/4/2015"),
                        Genre = "Adventure",
                        Price = 7.99M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 2}
                        }
                    },

                    new Movie
                    {
                        Title = "The Legend of Tarzan",
                        ReleaseDate = DateTime.Parse("6/29/2016"),
                        Genre = "Drama",
                        Price = 22.95M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 4},
                            new Review {Score = 3}
                        }
                    },

                    new Movie
                    {
                        Title = "The Chronicles of Narnia: The Lion, the Witch and the Wardrobe",
                        ReleaseDate = DateTime.Parse("12/7/2005"),
                        Genre = "Adventure",
                        Price = 26.99M,
                        Rating = "PG",
                        Reviews = new List<Review> {
                            new Review {Score = 5},
                            new Review {Score = 3}
                        }
                    },

                    new Movie
                    {
                        Title = "X-Men: Apocalypse",
                        ReleaseDate = DateTime.Parse("5/18/2016"),
                        Genre = "Action",
                        Price = 10.99M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 5},
                            new Review {Score = 2},
                            new Review {Score = 4}
                        }
                    },

                    new Movie
                    {
                        Title = "The Dark Knight",
                        ReleaseDate = DateTime.Parse("7/16/2008"),
                        Genre = "Crime",
                        Price = 22.95M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 2},
                            new Review {Score = 4},
                            new Review {Score = 5}
                        }
                    },

                    new Movie
                    {
                        Title = "Up",
                        ReleaseDate = DateTime.Parse("5/13/2009"),
                        Genre = "Animation",
                        Price = 9.99M,
                        Rating = "PG",
                        Reviews = new List<Review> {
                            new Review {Score = 4},
                            new Review {Score = 1}
                        }
                    },

                    new Movie
                    {
                        Title = "Monsters vs. Aliens",
                        ReleaseDate = DateTime.Parse("3/19/2009"),
                        Genre = "Animation",
                        Price = 22.95M,
                        Rating = "PG",
                        Reviews = new List<Review> {
                            new Review {Score = 1},
                            new Review {Score = 3},
                            new Review {Score = 1}
                        }
                    },

                    new Movie
                    {
                        Title = "Iron Man",
                        ReleaseDate = DateTime.Parse("4/30/2008"),
                        Genre = "Action",
                        Price = 20.0M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 3},
                            new Review {Score = 2},
                            new Review {Score = 3}
                        }
                    },

                    new Movie
                    {
                        Title = "Hugo",
                        ReleaseDate = DateTime.Parse("11/22/2011"),
                        Genre = "Family",
                        Price = 10.99M,
                        Rating = "PG",
                        Reviews = new List<Review> {
                            new Review {Score = 5},
                            new Review {Score = 1}
                        }
                    },

                    new Movie
                    {
                        Title = "Wild Wild West",
                        ReleaseDate = DateTime.Parse("6/29/1999"),
                        Genre = "Comedy",
                        Price = 27.0M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 1},
                            new Review {Score = 4}
                        }
                    },

                    new Movie
                    {
                        Title = "The Mummy: Tomb of the Dragon Emperor",
                        ReleaseDate = DateTime.Parse("7/1/2008"),
                        Genre = "Horror",
                        Price = 19.99M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 4}
                        }
                    },

                    new Movie
                    {
                        Title = "Suicide Squad",
                        ReleaseDate = DateTime.Parse("8/2/2016"),
                        Genre = "Comedy",
                        Price = 25.0M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 3}
                        }
                    },

                    new Movie
                    {
                        Title = "Evan Almighty",
                        ReleaseDate = DateTime.Parse("6/9/2007"),
                        Genre = "Fantasy",
                        Price = 9.95M,
                        Rating = "PG",
                        Reviews = new List<Review> {
                            new Review {Score = 2}
                        }
                    },

                    new Movie
                    {
                        Title = "Edge of Tomorrow",
                        ReleaseDate = DateTime.Parse("5/27/2014"),
                        Genre = "Action",
                        Price = 22.95M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 1},
                            new Review {Score = 3},
                            new Review {Score = 2}
                        }
                    },

                    new Movie
                    {
                        Title = "Waterworld",
                        ReleaseDate = DateTime.Parse("7/28/1995"),
                        Genre = "Adventure",
                        Price = 10.99M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 4},
                            new Review {Score = 1}
                        }
                    },

                    new Movie
                    {
                        Title = "G.I. Joe: The Rise of Cobra",
                        ReleaseDate = DateTime.Parse("8/4/2009"),
                        Genre = "Sci-Fi",
                        Price = 20.0M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 2},
                            new Review {Score = 1}
                        }
                    },

                    new Movie
                    {
                        Title = "Inside Out",
                        ReleaseDate = DateTime.Parse("6/9/2015"),
                        Genre = "Fantasy",
                        Price = 19.95M,
                        Rating = "PG",
                        Reviews = new List<Review> {
                            new Review {Score = 4},
                            new Review {Score = 2},
                            new Review {Score = 2}
                        }
                    },

                    new Movie
                    {
                        Title = "The Jungle Book",
                        ReleaseDate = DateTime.Parse("4/7/2016"),
                        Genre = "Family",
                        Price = 29.99M,
                        Rating = "PG",
                        Reviews = new List<Review> {
                            new Review {Score = 3},
                            new Review {Score = 1},
                            new Review {Score = 2}
                        }
                    },

                    new Movie
                    {
                        Title = "Iron Man 2",
                        ReleaseDate = DateTime.Parse("4/28/2010"),
                        Genre = "Action",
                        Price = 15.99M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 3},
                            new Review {Score = 5}
                        }
                    },

                    new Movie
                    {
                        Title = "Snow White and the Huntsman",
                        ReleaseDate = DateTime.Parse("5/30/2012"),
                        Genre = "Fantasy",
                        Price = 12.95M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 5},
                            new Review {Score = 4},
                            new Review {Score = 4}
                        }
                    },

                    new Movie
                    {
                        Title = "Maleficent",
                        ReleaseDate = DateTime.Parse("5/28/2014"),
                        Genre = "Fantasy",
                        Price = 9.99M,
                        Rating = "PG",
                        Reviews = new List<Review> {
                            new Review {Score = 4}
                        }
                    },

                    new Movie
                    {
                        Title = "Dawn of the Planet of the Apes",
                        ReleaseDate = DateTime.Parse("6/26/2014"),
                        Genre = "Adventure",
                        Price = 19.99M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 3},
                            new Review {Score = 3},
                            new Review {Score = 2}
                        }
                    },

                    new Movie
                    {
                        Title = "The Lovers",
                        ReleaseDate = DateTime.Parse("2/13/2015"),
                        Genre = "Romance",
                        Price = 9.99M,
                        Rating = "R",
                        Reviews = new List<Review> {
                            new Review {Score = 2},
                            new Review {Score = 1},
                            new Review {Score = 1}
                        }
                    },

                    new Movie
                    {
                        Title = "47 Ronin",
                        ReleaseDate = DateTime.Parse("12/6/2013"),
                        Genre = "Adventure",
                        Price = 5.99M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 2}
                        }
                    },

                    new Movie
                    {
                        Title = "Captain America: The Winter Soldier",
                        ReleaseDate = DateTime.Parse("3/20/2014"),
                        Genre = "Sci-Fi",
                        Price = 27.0M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 2}
                        }
                    },

                    new Movie
                    {
                        Title = "Shrek Forever After",
                        ReleaseDate = DateTime.Parse("5/16/2010"),
                        Genre = "Adventure",
                        Price = 19.95M,
                        Rating = "PG",
                        Reviews = new List<Review> {
                            new Review {Score = 3}
                        }
                    },

                    new Movie
                    {
                        Title = "Tomorrowland",
                        ReleaseDate = DateTime.Parse("5/19/2015"),
                        Genre = "Family",
                        Price = 13.95M,
                        Rating = "PG",
                        Reviews = new List<Review> {
                            new Review {Score = 4},
                            new Review {Score = 2},
                            new Review {Score = 5}
                        }
                    },

                    new Movie
                    {
                        Title = "Big Hero 6",
                        ReleaseDate = DateTime.Parse("10/24/2014"),
                        Genre = "Action",
                        Price = 9.99M,
                        Rating = "PG",
                        Reviews = new List<Review> {
                            new Review {Score = 3},
                            new Review {Score = 3},
                            new Review {Score = 3}
                        }
                    },

                    new Movie
                    {
                        Title = "Wreck-It Ralph",
                        ReleaseDate = DateTime.Parse("11/1/2012"),
                        Genre = "Family",
                        Price = 13.95M,
                        Rating = "PG",
                        Reviews = new List<Review> {
                            new Review {Score = 5},
                            new Review {Score = 3},
                            new Review {Score = 4}
                        }
                    },

                    new Movie
                    {
                        Title = "The Polar Express",
                        ReleaseDate = DateTime.Parse("11/10/2004"),
                        Genre = "Fantasy",
                        Price = 9.99M,
                        Rating = "G",
                        Reviews = new List<Review> {
                            new Review {Score = 5},
                            new Review {Score = 3}
                        }
                    },

                    new Movie
                    {
                        Title = "Independence Day: Resurgence",
                        ReleaseDate = DateTime.Parse("6/22/2016"),
                        Genre = "Action",
                        Price = 22.95M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 1},
                            new Review {Score = 5}
                        }
                    },

                    new Movie
                    {
                        Title = "How to Train Your Dragon",
                        ReleaseDate = DateTime.Parse("3/5/2010"),
                        Genre = "Fantasy",
                        Price = 10.99M,
                        Rating = "PG",
                        Reviews = new List<Review> {
                            new Review {Score = 4}
                        }
                    },

                    new Movie
                    {
                        Title = "Terminator 3: Rise of the Machines",
                        ReleaseDate = DateTime.Parse("7/2/2003"),
                        Genre = "Action",
                        Price = 24.95M,
                        Rating = "R",
                        Reviews = new List<Review> {
                            new Review {Score = 1},
                            new Review {Score = 1}
                        }
                    },

                    new Movie
                    {
                        Title = "Guardians of the Galaxy",
                        ReleaseDate = DateTime.Parse("7/30/2014"),
                        Genre = "Sci-Fi",
                        Price = 5.99M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 1},
                            new Review {Score = 5}
                        }
                    },

                    new Movie
                    {
                        Title = "Interstellar",
                        ReleaseDate = DateTime.Parse("11/5/2014"),
                        Genre = "Adventure",
                        Price = 14.99M,
                        Rating = "PG-13",
                        Reviews = new List<Review> {
                            new Review {Score = 2}
                        }
                    }

                );
                context.SaveChanges();
            }
        }
    }
}