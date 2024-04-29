using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using simple_crud.Db;
using simple_crud.Interfaces;
using simple_crud.Models;

namespace simple_crud.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext _context;
        public BookRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Book> CreateBook(Book book)
        {
            _context.Books.Add(book);
            await _context.SaveChangesAsync();
            return book;
        }

        public async Task<bool> DeleteBook(int id)
        {
            var book = await _context.Books.FindAsync(id);
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<Book> GetBookById(int id)
        {
            return await _context.Books.FindAsync(id);
        }

        public async Task<List<Book>> GetBooks()
        {
            return await _context.Books.ToListAsync();
        }

        public async Task<Book> UpdateBook(int id, Book book)
        {
            var existingBook = await _context.Books.FindAsync(id);
            existingBook.Name = book.Name;
            existingBook.Price = book.Price;
            existingBook.ImagePath = book.ImagePath;

            await _context.SaveChangesAsync();
            return existingBook;
        }
    }
}