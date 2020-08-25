using System.Collections.Generic;
using MovieRentals.Models;

namespace MovieRentals.ViewModels
{
    public class MovieRentalDetailsModel
    {
        public Movie Movie {get; set;}
        public List<Customer> Customers = new List<Customer>();
    }
}