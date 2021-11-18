using System;
using System.Collections.Generic;
using System.Text;


namespace MockBuster
{
    class Program
    {
        public static User moviesRepo;
        public static bool isAdmin = false;

        static void Main(string[] args)
        {
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("                      Welcome to Mockbuster!                               ");
            Console.WriteLine("             You're Our Only Customer So You're Always Right!               ");
            Console.WriteLine("**************************************************************************");
            Console.Write("Are you a 1. User or 2. Administrator? Please enter 1 or 2: ");
            var isAdminInput = Console.ReadLine();
            int.TryParse(isAdminInput, out var isAdminInputInt);
            isAdmin = isAdminInputInt == (int)Constants.UserType.Admin;

           if (isAdmin)
                {
                moviesRepo = new Admin();
            }
            else
            {
                moviesRepo = new User();
            }
            while (true)
            {
                PrintOptions();
                Console.Write("Please enter an option: ");
                var option = Console.ReadLine();

                if (!int.TryParse(option, out var optionInt))
                {
                    Console.WriteLine("Please enter a valid number!");
                    continue;
                }

                if (!isAdmin && optionInt >= (int)Constants.InputOptions.AddMovie)
                {
                    Console.WriteLine("Please enter one of the above options!");
                    continue;
                }

                switch (optionInt)
                {
                    case (int) Constants.InputOptions.Exit:
                        return;

                    case (int)Constants.InputOptions.SearchByMovieName:
                        Console.Write("Please enter a movie name: ");
                        var movieName = Console.ReadLine();
                        PrintSearchResults(moviesRepo.SearchByMovieName(movieName));
                        break;

                    case (int)Constants.InputOptions.SearchByGenre:
                        Console.Write("Please enter a movie genre: ");
                        var movieGenre = Console.ReadLine();
                        PrintSearchResults(moviesRepo.SearchByGenre(movieGenre));
                        break;

                    case (int)Constants.InputOptions.SearchByDirector:
                        Console.Write("Please enter a director: ");
                        var movieDirector = Console.ReadLine();
                        PrintSearchResults(moviesRepo.SearchByDirector(movieDirector));
                        break;

                    case (int)Constants.InputOptions.SearchByMainActor:
                        Console.Write("Please enter an actor: ");
                        var movieMainActor = Console.ReadLine();
                        PrintSearchResults(moviesRepo.SearchByMainActor(movieMainActor));
                        break;

                    case (int)Constants.InputOptions.AddMovie:
                        Console.Write("Please enter the movie's name: ");
                        var mMovieName = Console.ReadLine();
                        Console.Write("Please enter the movie's genre: ");
                        var mMovieGenre = Console.ReadLine();
                        Console.Write("Please enter the movie's director: ");
                        var mMovieDirector = Console.ReadLine();
                        Console.Write("Please enter the movie's main actor: ");
                        var mMovieMainActor = Console.ReadLine();
                        ((Admin)moviesRepo).AddMovie(mMovieName, mMovieGenre, mMovieDirector, mMovieMainActor);
                        break;

                    case (int)Constants.InputOptions.UpdateMovie:
                        var movies = moviesRepo.GetMovies();
                        for (int i = 0; i < movies.Count; i++)
                        {
                            Console.WriteLine($"{i}. {movies[i].ToString()}");
                        }
                        Console.Write("Please choose a movie: ");
                        var movieOption = Console.ReadLine();
                        if (!int.TryParse(movieOption, out var movieOptionInt))
                        {
                            Console.WriteLine("Please enter a valid number!");
                            break;
                        }

                        PrintUpdateOptions();
                        Console.Write("Please enter a field: ");
                        var fieldOption = Console.ReadLine();
                        if (!int.TryParse(fieldOption, out var fieldOptionInt))
                        {
                            Console.WriteLine("Please enter a valid number!");
                            break;
                        }

                        Console.WriteLine("Please enter new value: ");
                        var fieldValue = Console.ReadLine();

                        switch (fieldOptionInt)
                        {
                            case (int)Constants.FieldOptions.Exit:
                                continue;
                            case (int)Constants.FieldOptions.MovieName:
                                ((Admin)moviesRepo).UpdateMovie(movies[movieOptionInt].MovieId.ToString(), movieName: fieldValue);
                                break;
                            case (int)Constants.FieldOptions.Genre:
                                ((Admin)moviesRepo).UpdateMovie(movies[movieOptionInt].MovieId.ToString(), genre: fieldValue);
                                break;
                            case (int)Constants.FieldOptions.Director:
                                ((Admin)moviesRepo).UpdateMovie(movies[movieOptionInt].MovieId.ToString(), director: fieldValue);
                                break;
                            case (int)Constants.FieldOptions.MainActor:
                                ((Admin)moviesRepo).UpdateMovie(movies[movieOptionInt].MovieId.ToString(), mainActor: fieldValue);
                                break;
                        }
                        break;
                    case (int)Constants.InputOptions.RemoveMovie:
                        var moviesToRemove = moviesRepo.GetMovies();
                        for (int i = 0; i < moviesToRemove.Count; i++)
                        {
                            Console.WriteLine($"{i}. {moviesToRemove[i].ToString()}");
                        }
                        Console.Write("Please choose a movie: ");
                        var movieOptionToRemove = Console.ReadLine();
                        if (!int.TryParse(movieOptionToRemove, out var movieOptionToRemoveInt))
                        {
                            Console.WriteLine("Please enter a valid number!");
                            break;
                        }
                        ((Admin)moviesRepo).RemoveMovie(moviesToRemove[movieOptionToRemoveInt]);
                        break;
                        default:
                        Console.WriteLine("Please enter one of the above options!");
                        break;
                }
                Console.WriteLine("**************************************************************************");
            }

        }

        public static void PrintOptions()
        {
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Search By Movie Name");
            Console.WriteLine("2. Search By Genre");
            Console.WriteLine("3. Search By Director");
            Console.WriteLine("4. Search By Main Actor");
            if (isAdmin)
            {
                Console.WriteLine("5. Add a Movie");
                Console.WriteLine("6. Update a Movie");
                Console.WriteLine("7. Remove a Movie");
               
            }
        }

        public static void PrintUpdateOptions()
        {
            Console.WriteLine("1. Movie Name");
            Console.WriteLine("2. Movie Genre");
            Console.WriteLine("3. Movie Director");
            Console.WriteLine("4. Movie Main Actor");
        }

        public static void PrintSearchResults(List<Movie> movies)
        {
            foreach(var movie in movies)
            {
                Console.WriteLine(movie.ToString());
            }
        }
    }
}









