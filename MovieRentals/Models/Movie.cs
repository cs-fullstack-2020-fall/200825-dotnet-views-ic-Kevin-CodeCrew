using System;

namespace MovieRentals.Models
{
    public class Movie
    {
        public int MovieId {get;set;}
        public string MovieName {get;set;}
        public string MovieGenre {get;set;}
        public int ReleaseYear {get;set;}

        public Movie(int id, string name, string genre, int release)
        {
            this.MovieId = id;
            this.MovieName = name;
            this.MovieGenre = genre;
            this.ReleaseYear = release;
        }
    }
}