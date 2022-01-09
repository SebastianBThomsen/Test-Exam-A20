using System.ComponentModel.DataAnnotations;

namespace AuthorAPI
{
    public class Book
    {
        public int ISBN { get; set; }
        [Required, MaxLength(40)]
        public string Title { get; set; }
        public int PublicationYear { get; set; }
        public int NumOfPages { get; set; }
        public string Genre { get; set; }

        public override string ToString()
        {
            return $"ISBN: {ISBN}" +
                   $"\nTitle: {Title}" +
                   $"\nPublication Year: {PublicationYear}" +
                   $"\nNumber of Pages: {NumOfPages}" +
                   $"\nGenre: {Genre}";
        }
    }
}