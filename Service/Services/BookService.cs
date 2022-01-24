using DomainLayer.Models;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class BookService : IBookService
    {
        private IRepository<Book> _repository;
        public BookService(IRepository<Book> repository)
        {
            _repository = repository;
        }
        public void DeleteBook(int Id)
        {
            Book book = GetBook(Id);
            _repository.Remove(book);
            _repository.SaveChanges();
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _repository.GetAll();
        }

        public Book GetBook(int Id)
        {
            return _repository.Get(Id);
        }

        public void InsertBook(Book book)
        {
            _repository.Insert(book);
        }

        public void UpdateBook(Book book)
        {
            _repository.Update(book);
        }
    }
}
