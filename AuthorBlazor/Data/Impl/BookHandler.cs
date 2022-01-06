using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Model;

namespace AuthorBlazor.Data.Impl
{
    public class BookHandler : IBookHandler
    {
        private readonly string URL = "https://localhost:5001";

        public Task AddBook(Book book)
        {
            throw new System.NotImplementedException();
        }

        public Task<IList<Book>> GetBooks()
        {
            throw new System.NotImplementedException();
        }

        public async Task DeleteBook(int bookId)
        {
            using HttpClient client = new();
            HttpResponseMessage responseMessage = await client.DeleteAsync($"{URL}/Book/{bookId}");
            if (!responseMessage.IsSuccessStatusCode)
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
        }
    }
}