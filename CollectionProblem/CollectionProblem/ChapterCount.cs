using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProblem
{
    internal class ChapterCount
    {
        public static int ChaptersToRead(int n, Dictionary<int, int> chapters, int k)
        {
            int chaptersToRead = 0;

            foreach (var chapter in chapters)
            {
                int startPage = chapter.Key;
                int endPage = chapter.Value;

                if (startPage < k && k > endPage)
                {
                    chaptersToRead++;
                }
                else if (startPage > k)
                {
                    chaptersToRead++;
                }
            }

            return chaptersToRead;
        }
    

    }
}
