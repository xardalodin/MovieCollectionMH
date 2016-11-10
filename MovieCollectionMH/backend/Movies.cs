using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCollectionMH.backend
{
    class Movies
    {
        private string movie;
        private string length;
        private string format;
        // add imdb LINK so can be open if you click it in listview.

        public string Movie { get { return movie; } set { movie = value; } }

        public string Length { get { return length; } set { length = value; } }

        public string Format { get { return format; } set { format = value; } }

        public Movies()
        {
           //do nothing
        }
        public Movies(string movie, string length, string format)
        {
            this.movie = movie;
            this.length = length;
            this.format = format;
        }  

    }
}
