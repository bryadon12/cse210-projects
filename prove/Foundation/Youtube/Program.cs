

Class Program
{
    static void main(String[] args)
    {
        List<Video> Videos = new List<Video>();



        Do
        {
            Video video = new Video()
            Console.WriteLine("Would you like to add a comment? (y/n)")
            while (Console.ReadLine() == "y")
            {
                video.AddComment();
            }
            videos.add(video);
            Console.WriteLine("would you like to enter another video? (y/n)")
        } while (Console.ReadLine().lower() == "y")

        foreach(Video video in Videos)
        {
            video.GetInfo();
        }
    }
}