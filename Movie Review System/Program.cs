namespace Movie_Review_Website;

public class program
{
    public static void Videolist(List<Video> VideoList)
    {

        Console.WriteLine("Is your Video a film, Online Video or Tv Show?");
        string Media = Console.ReadLine();
        Media = Media.ToLower();
        Console.WriteLine("You have selected " + Media);
        switch (Media)
        {
            case "film":

                break;

            case "tv show":

                break;

            case "online video":

                break;


        }


        Video VideoName = new Video("Genre", 228, 15, "Title", 3, "writtenReview");
        Video VideoName2 = new Video("Genre2", 229, 18, "Title2", 4, "writtenReview2");
        Video VideoName3 = new Video("Genre3", 230, 21, "Title3", 5, "writtenReview3");
        VideoList.Add(VideoName);
        VideoList.Add(VideoName2);
        VideoList.Add(VideoName3);

    }


    public static void Main(string[] args)
    {

        List<Video> VideoList = new List<Video>();

        Videolist(VideoList);
        Console.WriteLine("What Genre is the video?");
        string Genre = Console.ReadLine();

        Console.WriteLine("What Length is the video in minutes?");
        long Length = long.Parse(Console.ReadLine());                          // Add a feature to stop crashing similar to the starRating

        Console.WriteLine("What AgeRating is the video?");
        int AgeRating = int.Parse(Console.ReadLine());                         // Add a feature to stop crashing similar to the starRating

        Console.WriteLine("What is the title of the video?");
        string Title = Console.ReadLine();

        int starRating = Video.Starrating();
        Console.WriteLine("You have chosen " + starRating + " stars");
        Console.WriteLine("Please leave a written review for this video:");
        string writtenReview = Console.ReadLine();
        Console.WriteLine(" ");
        Video newVideo = new Video(Genre, Length, AgeRating, Title, starRating, writtenReview);
        Console.WriteLine("The Video genre is " + newVideo.Genre);
        Console.WriteLine("The Video Length in minutes is " + newVideo.Length);
        Console.WriteLine("The Age Rating is " + newVideo.AgeRating);
        newVideo.ageRating(AgeRating);        
        Console.WriteLine("The title of the video is " + newVideo.Title);
        Console.WriteLine(" ");
        Console.WriteLine("You have rated this video " + newVideo.starRating + " Stars");
        Console.WriteLine(" ");
        Console.WriteLine("Your written review for this video is: " + newVideo.writtenReview);





    }
}


