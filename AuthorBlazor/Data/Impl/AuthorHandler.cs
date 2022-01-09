using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Model;

namespace AuthorBlazor.Data.Impl
{
    public class AuthorHandler : IAuthorHandler
    {
        private readonly string URL = "https://localhost:5001";

        public async Task AddAuthor(Author author)
        {
            using HttpClient client = new();

            string authorAsJson = JsonSerializer.Serialize(author);

            StringContent content = new StringContent(
                authorAsJson,
                Encoding.UTF8,
                "application/json"
            );
            HttpResponseMessage responseMessage = await client.PostAsync($"{URL}/Author", content);
            if (!responseMessage.IsSuccessStatusCode)
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
        }

        public async Task<IList<Author>> GetAuthors()
        {
            using HttpClient client = new();

            HttpResponseMessage responseMessage = await client.GetAsync($"{URL}/Author");

            if (!responseMessage.IsSuccessStatusCode)
                throw new Exception($"{responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");

            string result = await responseMessage.Content.ReadAsStringAsync();

            IList<Author> authors = JsonSerializer.Deserialize<IList<Author>>(result, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });

            return authors;
        }
    }
}