using System;
using System.Collections.Generic;
using System.Text;

namespace MockBuster
{
    public class Movie
    {
        public Guid MovieId { get; set; }          //Some info from the list could be the same(title, genre, director, main actor)-Guid gives a unique identifier to each object
        public string MovieName { get; set; }
        public string MainActor { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }


        public Movie(string movieName, string mainActor, string genre, string director)
        {
            MovieId = Guid.NewGuid();
            MovieName = movieName;
            MainActor = mainActor;
            Genre = genre;
            Director = director;
        }



        //override to string method to print movie name, main actor, genre, director
        public override string ToString()
        {
            return $"Movie Name: {MovieName}, Main Actor: {MainActor}, Genre: {Genre}, Director: {Director}";
        }
  

    }
}
