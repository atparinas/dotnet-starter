using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StartedGuide.Data.Models;
using StartedGuide.Data.ViewModels;

namespace StartedGuide.Data.Services
{
    public class BookService
    {

        private readonly AppDbContext _context;
        
        public BookService(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddBook(BookViewModel book)
        {
            var _book = new Book
            {
                Title = book.Title,
                Description = book.Description,
                IsRead = book.IsRead,
                DateRead = book.IsRead ? book.DateRead.Value : null,
                Rate = book.IsRead? book.Rate.Value : null,
                Genre = book.Genre,
                CoverUrl = book.CoverUrl,
                Author = book.Author
            };

            _context.Books.Add(_book);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Book>> ListAllBooks()
        {
            return await _context.Books.ToListAsync();
        }

        public async Task<Book> GetBookById(int id)
        {
            return await _context.Books.FindAsync(id);
        }

        public async Task<Book> UpdateBook(int id, BookViewModel book)
        {
            var _book = await _context.Books.FindAsync(id);

            if (_book != null)
            {
                _book.Title = book.Title;
                _book.Description = book.Description;
                _book.IsRead = book.IsRead;
                _book.DateRead = book.IsRead ? book.DateRead.Value : null;
                _book.Rate = book.IsRead ? book.Rate.Value : null;
                _book.Genre = book.Genre;
                _book.CoverUrl = book.CoverUrl;
                _book.Author = book.Author;

                await _context.SaveChangesAsync();
            }

            return _book;

        }

        public async Task<bool> DeleteBookById(int id)
        {
            var _book = await _context.Books.FindAsync(id);

            if (_book != null)
            {
                _context.Books.Remove(_book);
                await _context.SaveChangesAsync();

                return true;
            }

            return false;
        }
    }
}