using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Review_Website
{
    public abstract class Online_Video : Video
    {
        ////////////////////////////Attributes




        ////////////////////////////Constructors/////////////////////////
        public Online_Video() : base(" ", 1, 2, " ", 5, " ")
        {

        }

        public Online_Video(string Genre, long Length, int AgeRating, string Title, int starRating, string writtenReview) : base(Genre, Length, AgeRating, Title, starRating, writtenReview)
        {

        }

        ///////////////////////////Methods///////////////////////////////
       
    }
}

