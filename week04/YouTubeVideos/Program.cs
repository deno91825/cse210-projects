using System;

class Program
{
    static void Main(string[] args)
    {

            // Create videos
            Video video1 = new Video("C# Basics", "Alice", 300);
            Video video2 = new Video("OOP Concepts", "Bob", 450);
            Video video3 = new Video("YouTube API Overview", "Charlie", 600);

          
            video1.AddComment(new Comment("Dave", "Great explanation!"));
            video1.AddComment(new Comment("Eve", "Very helpful."));
            video1.AddComment(new Comment("Frank", "Thanks for sharing."));

           
            video2.AddComment(new Comment("Grace", "I love OOP!"));
            video2.AddComment(new Comment("Heidi", "Could you make a part 2?"));
            video2.AddComment(new Comment("Ivan", "Awesome video."));

           
            video3.AddComment(new Comment("Judy", "Clear and concise."));
            video3.AddComment(new Comment("Karl", "Nice demo."));
            video3.AddComment(new Comment("Leo", "I learned a lot."));

            
            List<Video> videos = new List<Video> { video1, video2, video3 };

            
            foreach (Video v in videos)
            {
                Console.WriteLine($"Title: {v.Title}");
                Console.WriteLine($"Author: {v.Author}");
                Console.WriteLine($"Length (seconds): {v.Length}");
                Console.WriteLine($"Number of Comments: {v.GetNumberOfComments()}");
                Console.WriteLine("Comments:");
                v.DisplayComments();
                Console.WriteLine(); 
            }
        }
    }
