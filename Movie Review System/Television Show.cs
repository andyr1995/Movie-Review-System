using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Review_Website
{
    public abstract class Television_Show : Video
    {
        ////////////////////////////Attributes




        ////////////////////////////Constructors/////////////////////////
        public Television_Show() : base(" ", 1, 2, " ", 5, " ")
        {

        }

        public Television_Show(string Genre, long Length, int AgeRating, string Title, int starRating, string writtenReview) : base(Genre, Length, AgeRating, Title, starRating, writtenReview)
        {

        }

        ///////////////////////////Methods///////////////////////////////
        public void Starrating(int starRating)
        {
            bool Rating = false;
            int starRating;
        }
    }

}

