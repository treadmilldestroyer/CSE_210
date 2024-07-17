using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
  
    static void Main(string[] args)
    {
        Video video1 = new Video("Video1", "Aaron", 120);
        Video video2 = new Video("Video2", "Michael", 240);
        Video video3 = new Video("Video3", "Aaron", 360);

        List<Video> videoList = new List<Video>()
        {
            video1, video2, video3
        };

        Comment comment1 = new Comment("Peter", "What a great video!");
        Comment comment2 = new Comment("James", "Fantastic artistry.");
        Comment comment3 = new Comment("John", "I can't wait for the next video!");
        Comment comment4 = new Comment("Lucy", "I can't believe this, I'm telling my friends about this!");
        Comment comment5 = new Comment("Mary", "You should continue to make videos like these.");
        Comment comment6 = new Comment("Adam", "You have a lot of skill!");
        Comment comment7 = new Comment("Matthew", "You are such and artist.");
        Comment comment8 = new Comment("Eve", "Splendid.");
        Comment comment9 = new Comment("Alma", "Amazing!");
        Comment comment10 = new Comment("Ammon", "Wonderful!!");


        List<Comment> commentList = new List<Comment>()
        {
            comment1, comment2, comment3, comment4, comment5, comment6, comment7, comment8, comment9, comment10
        };

        Random random = new Random();
        foreach (Video video in videoList)
        {
            HashSet<int> chosenIndices = new HashSet<int>();
            while (chosenIndices.Count < 3)
            {
                int index = random.Next(commentList.Count);
                if (!chosenIndices.Contains(index))
                {
                    chosenIndices.Add(index);
                    video.AddComments(commentList[index]);
                }
            }
        }

        foreach (Video video in videoList)
        {
            video.DisplayVideoInfo(); 
            Console.WriteLine();
        }
    }
}