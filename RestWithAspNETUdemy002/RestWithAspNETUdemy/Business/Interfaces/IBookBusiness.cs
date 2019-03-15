using RestWithAspNETUdemy.Data.VO;
using RestWithAspNETUdemy.Model;
using RestWithAspNETUdemy.Repository.Generic;
using System.Collections.Generic;

namespace RestWithAspNETUdemy.Business.Interfaces
{
    public interface IBookBusiness
    {
        BookVO Create(BookVO book);
        BookVO FindById(long id);
        List<BookVO> FindAll();
        BookVO Update(BookVO book);
        void Delete(long id);
        bool Exists(long? id);
    }
}
