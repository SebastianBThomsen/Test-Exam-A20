using System.Collections.Generic;
using System.Threading.Tasks;
using Model;

namespace AuthorBlazor.Data
{
    public interface IAuthorHandler
    {
        Task AddAuthor(Author author);
        Task<IList<Author>> GetAuthors();
    }
}