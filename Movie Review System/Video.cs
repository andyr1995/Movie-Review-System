using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Review_Website
{
    public class Video
    {
        ////////////////////////////Attributes///////////////////

        public string Genre { get; private set; }
        public long Length { get; private set; }
        public int AgeRating { get; private set; }
        public string Title { get; private set; }
        public DateTime ReleaseDate { get; private set; }
        public int starRating { get; private set; }
        public string writtenReview { get; private set; }


        //////////// Consider adding the review out of 5 stars and also a small descripion of the review //////



        ////////////////////////////Constructors/////////////////////////

        public Video(string Genre, long Length, int AgeRating, string Title, int starRating, string writtenReview)
        {
            this.Genre = Genre;
            this.Length = Length;
            this.AgeRating = AgeRating;
            this.Title = Title;
            this.starRating = starRating;
            this.writtenReview = writtenReview;

        }

        public Video() : this(" ", 1, 2, " ", 5, " ")
        {

        }
        ///////////////////////////Methods///////////////////////////////

        public static int Starrating()
        {
            bool Rating = false;

            int starRating;
            Console.WriteLine("Please enter your rating our of 5 stars");
            do
            {
               
                bool checkrating = int.TryParse(Console.ReadLine(), out starRating);
                if (checkrating == true)
                {


                    if (starRating > 5 || starRating < 1)
                    {
                        Console.WriteLine("please enter a value between 1 and 5");
                    }

                    else
                    {
                        Rating = true;
                        Console.WriteLine("thank you for your rating");
                    }
                }
                else
                {
                    Console.WriteLine("please enter a value between 1 and 5");
                }



            }
            while (!Rating);
            return starRating;



        }

        public void ageRating(int AgeRating)
        {

            if (AgeRating >= 18)
            {
                Console.WriteLine("Suitable for Adults only");
            }

            else if (AgeRating < 18 && AgeRating > 15)
            {
                Console.WriteLine("Suitable for over 15's");
            }

            else if (AgeRating < 15 && AgeRating > 12)
            {
                Console.WriteLine("Suitable for over 12's");
            }

            else if (AgeRating < 12 && AgeRating > 5)
            {
                Console.WriteLine("Suitable for ages 5 and up");
            }

            else if (AgeRating < 5 && AgeRating > 0)
            {
                Console.WriteLine("Suitable for all ages");
            }

        }
    }
}
