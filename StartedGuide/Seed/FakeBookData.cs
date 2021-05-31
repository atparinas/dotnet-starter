using System;
using System.Collections.Generic;
using StartedGuide.Data.Models;

namespace StartedGuide.Seed
{
    public class FakeBookData
    {
        public List<Book> Books { get; }

        public FakeBookData()
        {
            Books = new List<Book>
            {
                new Book
                {
                    Title = "Game of Thrones",
                    Description = "Book Description here..",
                    IsRead = false,
                    CoverUrl = "https://...",
                    Genre = "Romance",
                    DateAdded = DateTime.Now,
                    Author = "GRR Martin"
                },
                new Book
                {
                    Title = "Wheel of Time",
                    Description = "Book Description here..",
                    IsRead = true,
                    DateRead = DateTime.Now,
                    Rate = 5,
                    CoverUrl = "https://...",
                    Genre = "Romance",
                    DateAdded = DateTime.Now,
                    Author = "Robert Jordan"
                },
                new Book
                {
                    Title = "Ways of Kings",
                    Description = "Book Description here..",
                    IsRead = true,
                    DateRead = DateTime.Now,
                    Rate = 5,
                    CoverUrl = "https://...",
                    Genre = "Romance",
                    DateAdded = DateTime.Now,
                    Author = "Brandon Sanderson"
                },
                
            };
        }
    }
}