using System;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("Video 1", "Author 1", 60);
        Video video2 = new Video("Video 2", "Author 2", 120);
        Video video3 = new Video("Video 3", "Author 3", 90);

        // Create comments for video 1
        video1.AddComment(new Comment("User 1", "Greate video!"));
        video1.AddComment(new Comment("User 2", "Helpful video"));
        video1.AddComment(new Comment("User 3", "Very informative"));

        // Create comments for video 2
        video2.AddComment(new Comment("User 4", "Great video!"));
        video2.AddComment(new Comment("User 5", "Informative video"));
        video2.AddComment(new Comment("User 6", "Helpful video"));

        // Create comments for video 3
        video3.AddComment(new Comment("User 7", "Great video!"));
        video3.AddComment(new Comment("User 8", "Informative video"));
        video3.AddComment(new Comment("User 9", "Helpful video"));

        // Put the videos into a list
        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Itearate through the list of videos and display the title and author
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.getTitle()}");
            Console.WriteLine($"Author: {video.getAuthor()}");
            Console.WriteLine($"Length: {video.getLength()} seconds");
            Console.WriteLine($"Number of comments: {video.getCommentCount()}");
            Console.WriteLine();

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"Comment: {comment.getCommentText()}");
                Console.WriteLine($"Author: {comment.getCommenterName()}");
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}