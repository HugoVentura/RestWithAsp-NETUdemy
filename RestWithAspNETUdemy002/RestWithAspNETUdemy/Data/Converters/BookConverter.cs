using RestWithAspNETUdemy.Data.Converter;
using RestWithAspNETUdemy.Data.VO;
using RestWithAspNETUdemy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithAspNETUdemy.Data.Converters
{
    public class BookConverter : IParser<BookVO, Book>, IParser<Book, BookVO>
    {
        public Book Parse(BookVO source)
        {
            if (source == null)
                return new Book();

            return new Book
            {
                Id = source.Id,
                Title = source.Title,
                Author = source.Author,
                LaunchDate = source.LaunchDate,
                Price = source.Price
            };
        }

        public BookVO Parse(Book source)
        {
            if (source == null)
                return new BookVO();

            return new BookVO
            {
                Id = source.Id,
                Title = source.Title,
                Author = source.Author,
                LaunchDate = source.LaunchDate,
                Price = source.Price
            };
        }

        public List<Book> ParseList(List<BookVO> source)
        {
            if (source == null)
                return new List<Book>();

            return source.Select(item => Parse(item)).ToList();
        }

        public List<BookVO> ParseList(List<Book> source)
        {
            if (source == null)
                return new List<BookVO>();

            return source.Select(item => Parse(item)).ToList();
        }
    }
}
