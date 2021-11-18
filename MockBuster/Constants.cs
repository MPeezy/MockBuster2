using System;
using System.Collections.Generic;
using System.Text;

namespace MockBuster
{
    public class Constants
    {
        public enum UserType
        {
            User = 1,
            Admin
        }

        public enum InputOptions
        {
            Exit = 0,
            SearchByMovieName,
            SearchByGenre,
            SearchByDirector,
            SearchByMainActor,
            AddMovie,
            UpdateMovie,
            RemoveMovie,
            SeeAllMovies        }

        public enum FieldOptions
        {
            Exit = 0,
            MovieName,
            Genre,
            Director,
            MainActor
        }
    }
}
