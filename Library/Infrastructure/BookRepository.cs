using Library.Models;

namespace Library.Infrastructure
{
    public class BookRepository
    {
        public Dictionary<int, Book> Books;

        private const string Content =
            "In the quiet town nestled between rolling hills, life moved at a gentle pace. The townsfolk went about their daily routines, exchanging pleasantries on cobblestone streets. Children played in the park, their laughter echoing through the air. Meanwhile, the local market buzzed with activity as vendors proudly displayed their wares. The aroma of freshly baked bread wafted from the bakery, enticing passersby. As the sun dipped below the horizon, painting the sky in hues of orange and pink, the town embraced the tranquility of the evening. It was a place where time seemed to stand still, creating a haven of peace and harmony.";

        public BookRepository()
        {
            Books = new Dictionary<int, Book>
            {
                { 1, new Book(1, "book 1","book 1 "+ Content) },
                { 2, new Book(2, "book 2","book 2 "+ Content) },
                { 3, new Book(3, "book 3","book 3 "+ Content) },
                { 4, new Book(4, "book 4","book 4 "+ Content) },
                { 5, new Book(5, "book 5","book 5 "+ Content) },
                { 6, new Book(6, "book 6","book 6 "+ Content) }
            };
        }
    }
}
