using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Amazon Influencer Program", "Ryan Hogue Passive Income", 7100);
        video1.AddComment(new Comment("John Doe", "This video was very helpful!"));
        video1.AddComment(new Comment("Jane Smith", "Great explanations, thank you!"));
        video1.AddComment(new Comment("Mike Johnson", "I learned a lot from this tutorial."));
        videos.Add(video1);

        Video video2 = new Video("Python Basics", "Code School", 900);
        video2.AddComment(new Comment("Alice Brown", "Awesome introduction to Python!"));
        video2.AddComment(new Comment("Bob White", "Very clear and easy to follow."));
        videos.Add(video2);

        Video video3 = new Video("JavaScript Tips", "Dev Guru", 600);
        video3.AddComment(new Comment("Charlie Green", "I love how concise this video is!"));
        video3.AddComment(new Comment("Eve Black", "Thank you for the tips, very useful!"));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}
