using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MockBuster
{
    public class User
    {
        public List<Movie> movies;

        public User()
        {
            movies = new List<Movie>
            {
                new Movie("Forrest Gump", "Tom Hanks", "Drama","Robert Zemeckis"),
                new Movie("Pretty Woman", "Julia Roberts", "Romantic Comedy", "Gary Marshall "),
                new Movie("Aladdin", "Robin Williams", "Animated", "Ron Clements"),
                new Movie("Men In Black", "Will Smith", "Action", "Barry Sonnenfeld"),
                new Movie("Total Recall", "Arnold Schwarzenegger", "Science Fiction", "Paul Verhoeven"),
                new Movie("Scream", "Courtney Cox", "Horror", "Wes Craven"),
                new Movie("The Lion King", "James Earl Jones", "Animated", "Roger Allers"),
                new Movie("Jurassic Park", "Jeff Goldblum", "Science Fiction", "Steven Spielberg"),

            };
        }

        public User(List<Movie> movies)
        {
            this.movies = movies;
        }

        public List<Movie> GetMovies()
        {
            return movies;
        }


        //User can return a list of movies by genre
        public List<Movie> SearchByGenre(string searchTerm)
        {
            var matchingMovies = new List<Movie>();
            foreach (var movie in movies)
            {
                if (movie.Genre.ToLower().Equals(searchTerm.ToLower()))
                {
                    matchingMovies.Add(movie);
                }
            }
            return matchingMovies;
        }



        //User can return a list of movies by movie name
        public List<Movie> SearchByMovieName(string searchTerm)
        {
            var matchingMovies = new List<Movie>();
            foreach (var movie in movies)
            {
                if (movie.MovieName.ToLower().Equals(searchTerm.ToLower()))
                {
                    matchingMovies.Add(movie);
                }
            }
            return matchingMovies;
        }



        //User can return a list of movies by main actor
        public List<Movie> SearchByMainActor(string searchTerm)
        {
            var matchingMovies = new List<Movie>();
            foreach (var movie in movies)
            {
                if (movie.MainActor.ToLower().Equals(searchTerm.ToLower()))
                {
                    matchingMovies.Add(movie);
                }
            }
            return matchingMovies;
        }



        //User can return a list of movies by director
        public List<Movie> SearchByDirector(string searchTerm)
        {
            var matchingMovies = new List<Movie>();
            foreach (var movie in movies)
            {
                if (movie.Director.ToLower().Equals(searchTerm.ToLower()))
                {
                    matchingMovies.Add(movie);
                }
            }
            return matchingMovies;
        }





    }
}




// public List<Movie> Movie { get; set; } = new List<Movie>();
//Don't need this-Already in movie class