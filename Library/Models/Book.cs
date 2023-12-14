using System.Collections.Concurrent;

namespace Library.Models
{
    public class Book
    {
        public Book(int id, string title, string content, FontSize fontSize= FontSize.Medium)
        {
            Id = id;
            Title = title;
            Content = content;
            BookSetting = new BookSetting(fontSize);
            Pages = CreatePages();
        }

        public int Id { get; }
        public string Title { get; }
        private string Content { get; }
        public BookSetting BookSetting { get; }
        public ConcurrentDictionary<int, string> Pages { get; private set; }
        public int PageCount { get; private set; }

        public void ChangeFontSize(FontSize size)
        {
            BookSetting.ChangeFontSize(size);
            CreatePages();
        }

       
        public ConcurrentDictionary<int,string> CreatePages()
        { 
            Pages = new ConcurrentDictionary<int, string>();

            var contentWords = Content.Split(' ');
            var totalPageCount = contentWords.Length / BookSetting.WordCountPerPage + (contentWords.Length % BookSetting.WordCountPerPage == 0 ? 0 : 1);

            Parallel.For(0, totalPageCount, i =>
            {
                var startWord = i * BookSetting.WordCountPerPage;
                var page = string.Join(" ", contentWords.Skip(startWord).Take(BookSetting.WordCountPerPage));

                Pages[i + 1] = page; // [i+1] just for enhancing readability
            });

            PageCount = Pages.Count;
            return Pages;
        }
        
    }
}
