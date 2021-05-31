using System;

namespace StartedGuide.Data.ViewModels
{
    public class BookViewModel
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public bool IsRead { get; set; }

        public DateTime? DateRead { get; set; }
        // ? makes the property optional

        public int? Rate { get; set; }

        public string CoverUrl { get; set; }

        public string Genre { get; set; }

        public string Author { get; set; }  

    }
}