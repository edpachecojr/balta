using System.Collections.Generic;

namespace Balta.ContentContext
{
    public class Career : Content
    {
        public IList<CareerItem> Items { get; set; }

        public Career(string title, string url) : base(title, url)
        {
            Items = new List<CareerItem>();
        }

        public int TotalCourses => Items.Count;
    }
}