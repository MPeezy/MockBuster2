using System;
using System.Collections.Generic;
using System.Text;

namespace MockBuster
{

    //Can do all methods from user class and has same filtering as user but can add, update and delete movies from repo
    public class Admin : User
    {

        //method to add a movie
        public void AddMovie(string movieName, string genre, string director, string mainActor)
        {
            movies.Add(new Movie(movieName, mainActor, genre, director));
            Console.WriteLine("Movie was added");
        }


        public void AddMovie(Movie movie)    //overload
        {
            movies.Add(movie);
        }

        //method to update movie
        public void UpdateMovie(string movieId, string movieName = null, string genre = null, string director = null, string mainActor = null)
        {
            foreach (var movie in movies)
            {
                if (movie.MovieId.ToString().Equals(movieId))
                {
                    if (director != null)
                    {
                        movie.Director = director;
                        Console.WriteLine("Director was updated.");
                    }
                    if (genre != null)
                    {
                        movie.Genre = genre;
                        Console.WriteLine("Genre was updated.");
                    }
                    if (movieName != null)
                    {
                        movie.MovieName = movieName;
                        Console.WriteLine("Movie name was updated.");
                    }
                    if (mainActor != null)
                    {
                        movie.MainActor = mainActor;
                        Console.WriteLine("Main actor was updated.");
                    }
                    break;
                }
            }
        }


        //method to remove movie from list
        public void RemoveMovie(string movieId)
        {
            foreach (var movie in movies)
            {
                if (movie.MovieId.ToString().Equals(movieId))
                {
                    movies.Remove(movie);
                    Console.WriteLine("Movie was removed");
                    break;
                }
            }
        }

        public void RemoveMovie(Movie movie)     //overload
        {
            movies.Remove(movie);
            Console.WriteLine("Movie was removed");
        }


      

    }
}









