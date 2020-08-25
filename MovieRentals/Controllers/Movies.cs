using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MovieRentals.Models;
using MovieRentals.ViewModels;

namespace MovieRentals.Controllers
{
    // Sanity check
    public class Movies : Controller
    {
        public List<Movie> MoviesList = new List<Movie>()
        {
            new Movie(0,"Star Wars","SciFi",1978),
            new Movie(1,"Star Wars: The Empire Strikes Back","SciFi",1980),
            new Movie(2,"Star Wars: Return of the Jedi","SciFi",1984)
        };

        public IActionResult MovieInfo(int id)
        {
            int movieIdx = MoviesList.FindIndex(m => m.MovieId == id);
            ViewData["id"] = id;
            // If we got a hit, add to context
            if (movieIdx > 0) // found movie
            {
                ViewData["name"] = MoviesList[movieIdx].MovieName;
                ViewData["genre"] = MoviesList[movieIdx].MovieGenre;
                ViewData["year"] = MoviesList[movieIdx].ReleaseYear;
            }
            return View();
        }

        public IActionResult MovieRentalHistory(int id)
        {
            MovieRentalDetailsModel rentalDetails = new MovieRentalDetailsModel();
            rentalDetails.Movie = new Movie(5, "Blade Runner", "SciFi", 1982);
            rentalDetails.Customers.Add(new Customer(0, "Kevin Yancy", true));
            rentalDetails.Customers.Add(new Customer(1, "Stuart Yancy", false));
            rentalDetails.Customers.Add(new Customer(2, "Albert Lawrence", true));
            return View(rentalDetails);
        }

    }
}