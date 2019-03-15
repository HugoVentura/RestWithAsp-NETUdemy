using RestWithAspNETUdemy.Model;
using RestWithAspNETUdemy.Repository.Generic;
using System.Collections.Generic;

namespace RestWithAspNETUdemy.Business.Interfaces
{
    public interface IBookBusiness
    {
        Book Create(Book book);
        Book FindById(long id);
        List<Book> FindAll();
        Book Update(Book book);
        void Delete(long id);
    }
}
