using System;

// We add public to the general class of the Program 
// to may be accessible to the other programs
public class Program
{
    static void Main(string[] args)
    {


    // Create a list to put videos in
        List<Video> _videos = new List<Video>();

        // Video 1 
        string title = " Amazing Trabel at Salt Lake";
        string author = "Samuel Rodas";
        int length = 300;
        Video video1 = new Video(title,author,length);
        _videos.Add(video1);
        
       
        
        // Video 1 comment
        string name = "BrendStyle_";
        string comment = "Wow, is a great travel to do";
        Comment vid1com1 = new Comment(name, comment);

        string name2 = "*Jamesbonds*";
        string comment2 = "How do make that ?";
        Comment vid1com2 = new Comment(name2,comment2);

        string name3 = ">>ValenSonic<<";
        string comment3 = "Do you know how much it cost?";
        Comment vid1com3 = new Comment(name3,comment3);

        video1._comments.Add(vid1com1);
        video1._comments.Add(vid1com2);
        video1._comments.Add(vid1com3);

        
        video1.DisplayAll();
        Console.WriteLine();

        // Video 2
        string title2 = "Cooking my cake";
        string author2 = "Stacy Stanley";
        int length2 = 252;
        Video video2 = new Video(title2,author2,length2);
        _videos.Add(video2);

        // Comments for Video 2
        string name4 = "JackRyan99";
        string comment4 = " I have never made that kind of cake.";
        Comment vid2com1 = new Comment(name4,comment4);

        string name5 = "SaraSpinner";
        string comment5 = "It's look amazing your work.";
        Comment vid2com2 = new Comment(name5,comment5);

        string name6 = "Will_22";
        string comment6 = "I will try to made that, thanks for the video!";
        Comment vid2com3 = new Comment(name6,comment6);

        video2._comments.Add(vid2com1);
        video2._comments.Add(vid2com2);
        video2._comments.Add(vid2com3);

        
        video2.DisplayAll();
        Console.WriteLine();

        // Video 3
        string title3 = "How to choose my phone";
        string author3 = "Tom Rush";
        int length3 = 420;
        Video video3 = new Video(title3,author3,length3);
        _videos.Add(video3);

        //Comments for Video 3
        string name7 = "Terry433";
        string comment7 = "This a great way to see what phone is better to me.";
        Comment vid3com1 = new Comment(name7,comment7);

        string name8 = "GreatWoodss";
        string comment8 = "Try to show more phones next time please.";
        Comment vid3com2 = new Comment(name8,comment8);

        string name9 = "JLDance";
        string comment9 = "Where is that store?";
        Comment vid3com3 = new Comment(name9,comment9);

        video3._comments.Add(vid3com1);
        video3._comments.Add(vid3com2);
        video3._comments.Add(vid3com3);

        
        video3.DisplayAll();
        Console.WriteLine();



    }

}