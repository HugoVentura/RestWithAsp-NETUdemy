using RestWithAspNETUdemy.Business.Interfaces;
using RestWithAspNETUdemy.Model;
using RestWithAspNETUdemy.Repository.Generic;
using System.Collections.Generic;

namespace RestWithAspNETUdemy.Business.Implementattions
{
    public class BookBusiness : IBookBusiness
    {
        private IRepositoryBase<Book> _repository;

        public BookBusiness(IRepositoryBase<Book> repository)
        {
            _repository = repository;
        }

        public Book Create(Book book)
        {
            return _repository.Create(book);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<Book> FindAll()
        {
            return _repository.FindAll();
        }

        public Book FindById(long id)
        {
            return _repository.FindById(id);
        }

        public Book Update(Book book)
        {
            return _repository.Update(book);
        }
    }
}
