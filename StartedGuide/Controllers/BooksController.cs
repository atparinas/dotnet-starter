using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StartedGuide.Data.Models;
using StartedGuide.Data.Services;
using StartedGuide.Data.ViewModels;

namespace StartedGuide.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly BookService _bookService;
        
        public BooksController(BookService bookService)
        {
            _bookService = bookService;

        }


        [HttpPost]
        public async Task<IActionResult> AddBook([FromBody] BookViewModel book)
        {
            await _bookService.AddBook(book);

            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult<List<Book>>> GetAllBooks()
        {
            var books = await _bookService.ListAllBooks();

            return Ok(books);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Book>> GetBookById(int id)
        {
            var book = await _bookService.GetBookById(id);

            return Ok(book);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<Book>> UpdateBook(int id, [FromBody] BookViewModel book)
        {
            var _book = await _bookService.UpdateBook(id, book);

            return Ok(_book);
        }

        
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            if (await _bookService.DeleteBookById(id))
            {
                return Ok();
            }

            return NotFound();
        }
        
    }
}