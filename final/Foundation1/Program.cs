using System;

class Program
{
    static void Main(string[] args)
    {
         Video video1 = new Video("How to bake a cake", "Emmanuel Aiyetan", 400);
        video1.AddComment(new Comment("Tobi", "Great recipe!"));
        video1.AddComment(new Comment("Dubby", "I love this tutorial!"));
        video1.AddComment(new Comment("Richard", "Can you make a video on how to make lasagna?"));

        
        Video video2 = new Video("Mastering Chess Openings", "Scott Kelvin", 600);
        video2.AddComment(new Comment("Samuel", "This really improved my opening strategy!"));
        video2.AddComment(new Comment("David", "Can you make one for endgames?"));
        video2.AddComment(new Comment("Francisca", "Super insightful, thanks!"));

        
        Video video3 = new Video("Beginner's Guide to Python", "Eniola Smith", 720);
        video3.AddComment(new Comment("Kelvin", "This made Python so easy to understand!"));
        video3.AddComment(new Comment("Dubby", "What IDE do you recommend for Python?"));
        video3.AddComment(new Comment("Richard", "I love how detailed this is!"));

        
        Video video4 = new Video("10-Minute Home Workout", "Samuel Ade", 300);
        video4.AddComment(new Comment("David", "This got me sweating in no time!"));
        video4.AddComment(new Comment("Francisca", "How often should I do this workout?"));
        video4.AddComment(new Comment("Tobi", "Great routine!"));

        
        video1.DisplayInfo();
        video2.DisplayInfo();
        video3.DisplayInfo();
        video4.DisplayInfo();
    

    }
}