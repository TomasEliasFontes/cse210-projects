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
        string title = "Magnet Fishing at Bass Lake";
        string author = "Sam Thomas";
        int length = 300;
        Video video1 = new Video(title,author,length);
        _videos.Add(video1);
        
       
        
        // Video 1 comment
        string name = "Sally Fry";
        string comment = "Where did you buy such a large maganet?";
        Comment vid1com1 = new Comment(name, comment);

        string name2 = "Micheal Ford";
        string comment2 = "I only ever get fishing hooks when I magnet fish.";
        Comment vid1com2 = new Comment(name2,comment2);

        string name3 = "Bill Worth";
        string comment3 = "Excited to see the next place you go.";
        Comment vid1com3 = new Comment(name3,comment3);

        video1._comments.Add(vid1com1);
        video1._comments.Add(vid1com2);
        video1._comments.Add(vid1com3);

        
        video1.DisplayAll();
        Console.WriteLine();

        // Video 2
        string title2 = "Touching my Toes";
        string author2 = "Ronald Breeks";
        int length2 = 252;
        Video video2 = new Video(title2,author2,length2);
        _videos.Add(video2);

        // Comments for Video 2
        string name4 = "Jack Mann";
        string comment4 = "Way to be, I have never been able to touch my toes.";
        Comment vid2com1 = new Comment(name4,comment4);

        string name5 = "Sarah Straight";
        string comment5 = "I love how you showed the whole process in one video.";
        Comment vid2com2 = new Comment(name5,comment5);

        string name6 = "Kate Mobile";
        string comment6 = "Now you should try learning to do the splits.";
        Comment vid2com3 = new Comment(name6,comment6);

        video2._comments.Add(vid2com1);
        video2._comments.Add(vid2com2);
        video2._comments.Add(vid2com3);

        
        video2.DisplayAll();
        Console.WriteLine();

        // Video 3
        string title3 = "Fixing my Kitchen Sink";
        string author3 = "Tom Rush";
        int length3 = 420;
        Video video3 = new Video(title3,author3,length3);
        _videos.Add(video3);

        //Comments for Video 3
        string name7 = "Terry Pickler";
        string comment7 = "Man this video helped me a lot, my faucet just bit the dust.";
        Comment vid3com1 = new Comment(name7,comment7);

        string name8 = "Perry Woods";
        string comment8 = "There is plumbers putty that can help with your problem.";
        Comment vid3com2 = new Comment(name8,comment8);

        string name9 = "Jenny Lance";
        string comment9 = "What a good husband!";
        Comment vid3com3 = new Comment(name9,comment9);

        video3._comments.Add(vid3com1);
        video3._comments.Add(vid3com2);
        video3._comments.Add(vid3com3);

        
        video3.DisplayAll();
        Console.WriteLine();



    }

}