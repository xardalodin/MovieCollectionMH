using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MovieCollectionMH.backend.json
{
    class json
    {
        public static void JsonSerial(List<backend.Movies> List,string Filname)
        {
            MovieList t = new MovieList();
            t.ListOfMovies = List;
            string temp = JsonConvert.SerializeObject(t);
            System.IO.File.WriteAllText(Filname, temp);
        }

    }
}
