using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdebtlyAdaptiveChallenge.model
{
    class NewsItemManager
    {
        public static List<NewsItem> GetNewsItems()
        {
            var items = new List<NewsItem>();

            items.Add(new NewsItem { Id = 6, Category = "Financial", Headline = "Cool Headline text", Subhead = "cool subline text but smaller", DateLine = "10/12/2016", Image = "assets/Financial1.png" });
            items.Add(new NewsItem { Id = 7, Category = "Financial", Headline = "Cool Headline text", Subhead = "cool subline text but smaller", DateLine = "10/12/2016", Image = "assets/Financial2.png" });
            items.Add(new NewsItem { Id = 8, Category = "Financial", Headline = "Cool Headline text", Subhead = "cool subline text but smaller", DateLine = "10/12/2016", Image = "assets/Financial3.png" });
            items.Add(new NewsItem { Id = 9, Category = "Financial", Headline = "Cool Headline text", Subhead = "cool subline text but smaller", DateLine = "10/12/2016", Image = "assets/Financial4.png" });
            items.Add(new NewsItem { Id = 10, Category = "Financial", Headline = "Cool Headline text", Subhead = "cool subline text but smaller", DateLine = "10/12/2016", Image = "assets/Financial5.png" });

            items.Add(new NewsItem { Id = 1, Category = "Food", Headline = "Cool Headline text", Subhead = "cool subline text but smaller", DateLine = "10/12/2016", Image = "assets/Food1.png" });
            items.Add(new NewsItem { Id = 2, Category = "Food", Headline = "Cool Headline text", Subhead = "cool subline text but smaller", DateLine = "10/12/2016", Image = "assets/Food2.png" });
            items.Add(new NewsItem { Id = 3, Category = "Food", Headline = "Cool Headline text", Subhead = "cool subline text but smaller", DateLine = "10/12/2016", Image = "assets/Food3.png" });
            items.Add(new NewsItem { Id = 4, Category = "Food", Headline = "Cool Headline text", Subhead = "cool subline text but smaller", DateLine = "10/12/2016", Image = "assets/Food4.png" });
            items.Add(new NewsItem { Id = 5, Category = "Food", Headline = "Cool Headline text", Subhead = "cool subline text but smaller", DateLine = "10/12/2016", Image = "assets/Food5.png" });

            return items;
        }
    }
}
