using System.Collections.Generic;

namespace StartedGuide.Data.Models
{
    public class Author
    {
        public int Id { get; set; }

        public string FullName { get; set; }
        
        //Navigation Properties
        public List<BookAuthor> BookAuthors { get; set; }
    }
}