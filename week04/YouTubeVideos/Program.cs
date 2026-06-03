using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video video1 = new Video();
        Video video2 = new Video();
        Video video3 = new Video();
        Video video4 = new Video();
        Comment v1Comment1 = new Comment();
        Comment v2Comment1 = new Comment();
        Comment v3Comment1 = new Comment();
        Comment v4Comment1 = new Comment();
        Comment v1Comment2 = new Comment();
        Comment v2Comment2 = new Comment();
        Comment v3Comment2 = new Comment();
        Comment v4Comment2 = new Comment();
        Comment v1Comment3 = new Comment();
        Comment v2Comment3 = new Comment();
        Comment v3Comment3 = new Comment();
        Comment v4Comment3 = new Comment();
        Comment v1Comment4 = new Comment();
        Comment v2Comment4 = new Comment();
        Comment v3Comment4 = new Comment();
        Comment v4Comment4 = new Comment();
        video1.SetTitle("How to Pray");
        video1.SetAuthor("Bishop Bishop");
        video1.SetVideoLength(300);
        v1Comment1.SetCommentersName("Joel");
        v1Comment2.SetCommentersName("Bill");
        v1Comment3.SetCommentersName("Harry");
        v1Comment4.SetCommentersName("Larry");
        v1Comment1.SetCommentText("Thanks again for your work Bishop Bishop");
        v1Comment2.SetCommentText("Great video as always");
        v1Comment3.SetCommentText("The Lord will always be with us");
        v1Comment4.SetCommentText("Thanks for the help");
        video1.AddComment(v1Comment1);
        video1.AddComment(v1Comment2);
        video1.AddComment(v1Comment3);
        video1.AddComment(v1Comment4);
        video2.SetTitle("How to Fish");
        video2.SetAuthor("Fisher Willy");
        video2.SetVideoLength(600);
        v2Comment1.SetCommentersName("Joel");
        v2Comment2.SetCommentersName("Bill");
        v2Comment3.SetCommentersName("Harry");
        v2Comment4.SetCommentersName("Larry");
        v2Comment1.SetCommentText("Thanks again for your work catchin' the big ones");
        v2Comment2.SetCommentText("Great video as always Willy");
        v2Comment3.SetCommentText("Thats a huge fish there.");
        v2Comment4.SetCommentText("Thanks for the help, now I gotta go catch me a fish");
        video2.AddComment(v2Comment1);
        video2.AddComment(v2Comment2);
        video2.AddComment(v2Comment3);
        video2.AddComment(v2Comment4);
        video3.SetTitle("How to Scare Your Friends");
        video3.SetAuthor("Joey Mcklison");
        video3.SetVideoLength(600);
        v3Comment1.SetCommentersName("Joel");
        v3Comment2.SetCommentersName("Bill");
        v3Comment3.SetCommentersName("Harry");
        v3Comment4.SetCommentersName("Larry");
        v3Comment1.SetCommentText("So funny how he jumped");
        v3Comment2.SetCommentText("Great video as always Joey");
        v3Comment3.SetCommentText("Thats a huge fish there. Where did you catch it");
        v3Comment4.SetCommentText("Thanks for the ideas, now time to make my friends jump in fright.");
        video3.AddComment(v3Comment1);
        video3.AddComment(v3Comment2);
        video3.AddComment(v3Comment3);
        video3.AddComment(v3Comment4);
        video4.SetTitle("What Happens If I Were to Crush this?");
        video4.SetAuthor("Crusher Bob");
        video4.SetVideoLength(900);
        v4Comment1.SetCommentersName("Joel");
        v4Comment2.SetCommentersName("Bill");
        v4Comment3.SetCommentersName("Harry");
        v4Comment4.SetCommentersName("Larry");
        v4Comment1.SetCommentText("Thanks again for your work, always satisfying to watch things get crushed");
        v4Comment2.SetCommentText("Great video as always Bob");
        v4Comment3.SetCommentText("Thats a huge machine you got there");
        v4Comment4.SetCommentText("Thanks for the satisfying video, now to binge and relax");
        video4.AddComment(v4Comment1);
        video4.AddComment(v4Comment2);
        video4.AddComment(v4Comment3);
        video4.AddComment(v4Comment4);
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);
        
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetVideoLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetTotalComments()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"  {comment.GetCommentersName()}: {comment.GetCommentText()}");
            }
            Console.WriteLine();
        }
    }
}