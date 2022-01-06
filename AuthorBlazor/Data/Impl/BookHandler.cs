using System.Collections.Generic;
using System.Threading.Tasks;
using Model;

namespace AuthorBlazor.Data.Impl
{
    public class BookHandler : IBookHandler
    {
        public Task AddBook(Book book)
        {
            throw new System.NotImplementedException();
        }

        public Task<IList<Book>> GetBooks()
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteBook(int bookId)
        {
            throw new System.NotImplementedException();
        }
    }
}