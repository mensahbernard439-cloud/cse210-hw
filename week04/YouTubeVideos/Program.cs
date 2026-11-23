using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Unboxing the New Studio Mic", "SoundCheckLab", 485);
        video1.AddComment(new Comment("Kwame Boateng", "Clear audio right out of the box."));
        video1.AddComment(new Comment("Elena Rostova", "Did you use any gain boost in post?"));
        video1.AddComment(new Comment("Tariq Hassan", "Spotted the boom arm feature around 3:15."));
        videos.Add(video1);

        Video video2 = new Video("10-Minute Desk Cable Cleanup", "CleanWorkspace", 612);
        video2.AddComment(new Comment("Rachel Lin", "Under-desk tray made a huge difference."));
        video2.AddComment(new Comment("Devon Brooks", "Simple setup and easy to follow."));
        video2.AddComment(new Comment("Nadia Mensah", "What Velcro ties are those?"));
        video2.AddComment(new Comment("Samir Patel", "Saved for my weekend workspace reset."));
        videos.Add(video2);

        Video video3 = new Video("Travel Backpack Packing Guide", "RoamDaily", 730);
        video3.AddComment(new Comment("Claire Dubois", "Compression cubes fit so much more."));
        video3.AddComment(new Comment("Mateo Silva", "Carried this same pack on a two-week trip."));
        video3.AddComment(new Comment("Grace Osei", "Helpful weight balance tips."));
        videos.Add(video3);

        Video video4 = new Video("Color Grading Basics for Beginners", "FrameByFrame", 845);
        video4.AddComment(new Comment("Jonas Lind", "Skin tones stayed natural throughout."));
        video4.AddComment(new Comment("Priya Nair", "Good explanation of scopes vs. eye test."));
        video4.AddComment(new Comment("Caleb Grant", "Watched twice to catch all the steps."));
        videos.Add(video4);

        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }

        Console.WriteLine("--------------------------------------------------");
    }
}