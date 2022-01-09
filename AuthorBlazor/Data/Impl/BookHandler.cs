using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Model;

namespace AuthorBlazor.Data.Impl
{
    public class BookHandler : IBookHandler
    {
        private readonly string URL = "https://localhost:5001";

        public async Task AddBook(Book book, int authorId)
        {
            using HttpClient client = new();

            string bookAsJson = JsonSerializer.Serialize(book);

            StringContent content = new StringContent(
                bookAsJson,
                Encoding.UTF8,
                "application/json"
            );
            HttpResponseMessage responseMessage = await client.PostAsync($"{URL}/Book/{authorId}", content);
            if (!responseMessage.IsSuccessStatusCode)
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
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