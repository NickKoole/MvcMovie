using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            if (context.Movie.Any())
            {
                return;
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "When Harry Met Sally",
                    Director = "Rob Reiner",
                    Genre = "Romantic Comedy-Drama",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Rating = 7.7,
                    MadeProfit = true
                },
                new Movie
                {
                    Title = "The Lord of the Rings: The Fellowship of the Ring",
                    Director = "Peter Jackson",
                    Genre = "High Fantasy",
                    ReleaseDate = DateTime.Parse("2002-12-19"),
                    Rating = 8.8,
                    MadeProfit = true
                },
                new Movie
                {
                    Title = "Ghostbusters 2",
                    Director = "Ivan Reitman",
                    Genre = "Sci-Fi Comedy",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Rating = 6.6,
                    MadeProfit = true
                },
                new Movie
                {
                    Title = "The Matrix",
                    Director = "The Wachowskis",
                    Genre = "Cyberpunk",
                    ReleaseDate = DateTime.Parse("1999-6-17"),
                    Rating = 8.7,
                    MadeProfit = true
                }
            );
            context.SaveChanges();
        }
    }
}