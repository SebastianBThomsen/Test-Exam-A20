﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Model;

namespace AuthorBlazor.Data
{
    public interface IBookHandler
    {
        Task AddBook(Book book, int authorId);
        Task<IList<Book>> GetBooks();
        Task DeleteBook(int bookId);
    }
}