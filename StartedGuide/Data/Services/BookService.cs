﻿using StartedGuide.Data.Models;
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

        public void AddBook(BookViewModel book)
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
            _context.SaveChanges();
        }
    }
}