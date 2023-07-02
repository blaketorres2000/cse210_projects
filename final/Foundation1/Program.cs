using System;

public class Program
{
    private static List<Video> videos = new List<Video>();

    public static void Main(string[] args)
    {
        CreateVideos();
        DisplayVideos();
    }

    public static void CreateVideos()
    {
        // Create and add videos to the list
        Video video1 = new Video();
        video1.SetTitle("Video 1");
        video1.SetAuthor("Author 1");
        video1.SetLength(120);
        video1.AddComment(new Comment("User1", "Comment 1"));
        video1.AddComment(new Comment("User2", "Comment 2"));
        video1.AddComment(new Comment("User3", "Comment 3"));

        Video video2 = new Video();
        video2.SetTitle("Video 2");
        video2.SetAuthor("Author 2");
        video2.SetLength(180);
        video2.AddComment(new Comment("User4", "Comment 4"));
        video2.AddComment(new Comment("User5", "Comment 5"));

        videos.Add(video1);
        videos.Add(video2);
    }

    public static void DisplayVideos()
    {
        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.GetTitle());
            Console.WriteLine("Author: " + video.GetAuthor());
            Console.WriteLine("Length: " + video.GetLength());
            Console.WriteLine("Number of Comments: " + video.GetNumberOfComments());
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(" - Comment by " + comment.GetName() + ": " + comment.GetText());
            }
            Console.WriteLine();
        }
    }
}