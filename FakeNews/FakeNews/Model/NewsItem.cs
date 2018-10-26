using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeNews.Model
{
    class NewsItem
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Headline { get; set; }
        public string Subhead { get; set; }
        public string Dateline { get; set; }
        public string Image { get; set; }
    }
    public class NewManager
    {
        public static void GetNews(string category,ObservableCollection<NewsItem> newsItems)
        {
            var allItems = getNewsItems();
            var filteredNewsItems = allItems.Where(p => p.Category == category).ToList();
            newsItems.Clear();

            filteredNewsItems.ForEach(p => newsItems.Add(p));
        }
    }
    private static List<NewsItem> GetNewsItems()
    {
        var items = new List<NewsItem>();
        
        items.Add(new NewsItem()
        {
            Id = 1,
            Category = "Finacial",
            Headline = "Lorem Ipsum",
            Subhead = "doro sit amet",
            Dateline = "Nunc tristique nec",
            Image = "Assets/Financial4.png"
        });
        items.Add(new NewsItem()
        {
            Id = 2,
            Category = "Finacial",
            Headline = "Etiam ac felis viverra",
            Subhead = "vulputate nisl ac aliquet nisi",
            Dateline = "tortor porttitor, eu fermentum ante congue",
            Image = "Assets/Financial5.png"
        });
        items.Add(new NewsItem()
        {
            Id = 3,
            Category = "Finacial",
            Headline = "Interger sed turpis erat",
            Subhead = "Sed quis henderit lorem, quis interdum dolor",
            Dateline = "in viverra metus facilisis sed",
            Image = "Assets/Financial3.png"
        });
        items.Add(new NewsItem()
        {
            Id = 4,
            Category = "Finacial",
            Headline = "Lorem Ipsum",
            Subhead = "doro sit amet",
            Dateline = "Nunc tristique nec",
            Image = "Assets/Financial4.png"
        });
        items.Add(new NewsItem()
        {
            Id = 5,
            Category = "Finacial",
            Headline = "Lorem Ipsum",
            Subhead = "doro sit amet",
            Dateline = "Nunc tristique nec",
            Image = "Assets/Financial5.png"
        });
        items.Add(new NewsItem()
        {
            Id = 6,
            Category = "Finacial",
            Headline = "Lorem Ipsum",
            Subhead = "doro sit amet",
            Dateline = "Nunc tristique nec",
            Image = "Assets/Food1.png"
        });
        items.Add(new NewsItem()
        {
            Id = 7,
            Category = "Finacial",
            Headline = "Lorem Ipsum",
            Subhead = "doro sit amet",
            Dateline = "Nunc tristique nec",
            Image = "Assets/Food2.png"
        });
        items.Add(new NewsItem()
        {
            Id = 8,
            Category = "Finacial",
            Headline = "Lorem Ipsum",
            Subhead = "doro sit amet",
            Dateline = "Nunc tristique nec",
            Image = "Assets/Food3.png"
        });
        items.Add(new NewsItem()
        {
            Id = 9,
            Category = "Finacial",
            Headline = "Lorem Ipsum",
            Subhead = "doro sit amet",
            Dateline = "Nunc tristique nec",
            Image = "Assets/Food4.png"
        });
        items.Add(new NewsItem()
        {
            Id = 10,
            Category = "Finacial",
            Headline = "Lorem Ipsum",
            Subhead = "doro sit amet",
            Dateline = "Nunc tristique nec",
            Image = "Assets/Food5.png"
        });
        return items;

    }
}
