using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video("Frank Sinatra", "That's Life (2008 Remastered)", 187);
        v1.AddComment("@aspasia2414", "For me this is one of Frank Sinatra's greatest songs. The music, the rythm and obviously The Voice.");
        v1.AddComment("@MM-kk8uh", "This song perfectly coincided with my first love, that was an amazing time and this song will always take me back to those wonderful days.");
        v1.AddComment("@AustingSnellAustinSnell", "This music really describes everything. Sometimes, you're feeling down, but you gotta pick yourself up and get back in the race because that's life.");
        videos.Add(v1);
    
        Video v2 = new Video("Oldies Zone", "The Chords - Sh Boom", 146);
        v2.AddComment("@PeterGriffin-kb2hf", "As a little kid I loved this song in cars. It's still my jam many years later lol");
        v2.AddComment("@ElectricoGamez", "This is that one song from the Cars movie from my childhood I'll never forget my whole life. Even if life was a dream for me, I'd still enjoy it anyway. :)");
        v2.AddComment("@Russianproductions", "One of my earliest memories, I used to watch cars when i was a child and this song is engraved into my memory");
        videos.Add(v2);

        Video v3 = new Video("RiulDoamnei", "Mr. Sandman - The Chordettes", 143);
        v3.AddComment("@ashleighs781", "i dont think enough people realize how amazing and difficult it is to achieve this sound. Their harmonies are so perfect and their voices mix together so well!");
        v3.AddComment("@afrozaakter2387", "One of the most sampled song in existence. But no one can beat the original.");
        v3.AddComment("@RoderickSmith-oz6sz", "This music just makes me feel happy.  It's like Christmas music without it having anything to do with Christmas.  Happy Holidays and Merry Christmas to all!");
        videos.Add(v3);

        foreach (Video v in videos)
        {
            Console.WriteLine(v.GetString());
            Console.WriteLine();
            Console.WriteLine(v.GetCommentString());
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
        }
    }
}