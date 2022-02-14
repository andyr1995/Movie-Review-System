using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Review_Website
{
    public abstract class Film : Video
    {
        ////////////////////////////Attributes




        ////////////////////////////Constructors/////////////////////////
        public Film() : base(" ", 1, 2, " ", 5, " ")
        {

        }

        public Film(string Genre, long Length, int AgeRating, string Title, int starRating, string writtenReview) : base(Genre, Length, AgeRating, Title, starRating, writtenReview)
        {

        }

        ///////////////////////////Methods///////////////////////////////
        

    }
}

