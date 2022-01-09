using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AuthorAPI
{
    public class Author
    {
        public int Id { get; set; }
        [Required, MaxLength(15)] public string FirstName { get; set; }
        [Required, MaxLength(15)] public string LastName { get; set; }
        public List<Book> Book { get; set; }

        public override string ToString()
        {
            string books = "";
            int bookNr = 0;

            if (Book != null)
            {
                foreach (var book in Book)
                {
                    bookNr++;
                    books += $"Book Number: {bookNr}" +
                             $"\n{book}\n";
                }
            }


            return $"Id: {Id}" +
                   $"\nFirstName: {FirstName}" +
                   $"\nLast Name: {LastName}" +
                   $"\n{books}";
        }
    }
}