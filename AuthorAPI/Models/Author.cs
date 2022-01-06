using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AuthorAPI
{
    public class Author
    {
        public int Id { get; set; }
        [Required, MaxLength(15) ]
        public string FirstName { get; set; }
        [Required, MaxLength(15)]
        public string LastName { get; set; }
        public List<Book> Book { get; set; }
    }
}