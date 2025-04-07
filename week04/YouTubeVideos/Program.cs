using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create list of videos
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("How to Cook Pasta", "Chef Emma", 300);
        video1.AddComment(new Comment("Alice", "This recipe is amazing!"));
        video1.AddComment(new Comment("Bob", "Tried it today, my family loved it."));
        video1.AddComment(new Comment("Carla", "Can I use gluten-free pasta?"));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("Morning Yoga Routine", "YogaWithSam", 600);
        video2.AddComment(new Comment("Dan", "Perfect way to start my day."));
        video2.AddComment(new Comment("Elena", "Your voice is so calming."));
        video2.AddComment(new Comment("Fiona", "Loved the stretches!"));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Top 5 Coding Tips", "CodeMaster", 480);
        video3.AddComment(new Comment("George", "Number 3 changed the game for me."));
        video3.AddComment(new Comment("Hannah", "Thanks for these tips!"));
        video3.AddComment(new Comment("Ivan", "Subscribed! Waiting for part 2."));
        videos.Add(video3);

        // Display video information and comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.Name}: {comment.Text}");
            }
            Console.WriteLine(new string('-', 40));
        }
    }
}
