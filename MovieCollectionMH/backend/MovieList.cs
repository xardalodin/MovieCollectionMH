using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCollectionMH.backend
{
    class MovieList
    {
        List<Movies> listOfMovie;

        public List<Movies> ListOfMovies { get { return listOfMovie; } set { listOfMovie = value; } }

        public MovieList()
        {
            listOfMovie = new List<Movies>();
        }

        public void addMovie(Movies m)
        {
            listOfMovie.Add(m);
        }
        // add a remove later 

    }
}
