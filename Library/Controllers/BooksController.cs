using Library.Models;
using Library.Services;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly BookService _bookService;

        public BooksController(BookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var books = _bookService.GetAllBooks();
            return Ok(books);
        }

        [HttpGet("{bookId}/{pageNumber}")]
        public IActionResult GetPage(int bookId, int pageNumber)
        {
            var page = _bookService.GetPage(bookId, pageNumber);
            return Ok(page);
        }

        [HttpPut("{bookId}/{fontSize}")]
        public IActionResult ChangeFontSize(int bookId, FontSize fontSize)
        {
            var book = _bookService.ChangeFontSize(bookId, fontSize);
            return Ok(book);
        }
    }
}