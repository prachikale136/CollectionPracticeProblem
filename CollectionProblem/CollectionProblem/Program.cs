using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProblem
{
    internal class Program
    {
        public static void Main(string[] args) 
        {
            int n = 4;
            int k = 7;

            Dictionary<int, int> chapters = new Dictionary<int, int>();

            chapters.Add(1, 4);
            chapters.Add(5, 7);
            chapters.Add(9, 16);
            chapters.Add(17, 26);

            int chaptersToRead = ChapterCount.ChaptersToRead(n, chapters, k);
            Console.WriteLine("The Number of Chapters to Read: " + chaptersToRead);
        }
    }
}