using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using simple_crud.Models;

namespace simple_crud.Interfaces
{
    public interface IBookRepository
    {
        public Task<List<Book>> GetBooks();
        public Task<Book> GetBookById(int id);
        public Task<Book> CreateBook(Book book);
        public Task<Book> UpdateBook(int id, Book book);
        public Task<bool> DeleteBook(int id);
    }
}