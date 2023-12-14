using Library.Infrastructure;
using Library.Models;

namespace Library.Services
{
    public class BookService
    {
        private readonly BookRepository _bookRepository;

        public BookService(BookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _bookRepository.Books.Values;
        }

        public string GetPage(int bookId, int pageNumber)
        {
            var exist = _bookRepository.Books.TryGetValue(bookId, out var book);

            if (!exist || book.Pages.IsEmpty)
                throw new ArgumentException($"The book with id {bookId} doesn't exist!");

            else if (book.Pages.Count < pageNumber)
                throw new ArgumentException($"The last page is {book.Pages.Count}");

            return book.Pages[pageNumber];

        }

        public Book ChangeFontSize(int bookId, FontSize fontSize)
        {
            var exist = _bookRepository.Books.TryGetValue(bookId, out var book);

            if (!exist || book.Pages.IsEmpty)
                throw new ArgumentException($"The book with id {bookId} not found!");

            if (book.BookSetting.FontSize == fontSize)
                return book;

            book.ChangeFontSize(fontSize);

            return book;
        }
    }
}
