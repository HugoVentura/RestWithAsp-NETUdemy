using RestWithAspNETUdemy.Data.Converter;
using RestWithAspNETUdemy.Data.VO;
using RestWithAspNETUdemy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithAspNETUdemy.Data.Converters
{
    public class PersonConverter : IParser<PersonVO, Person>, IParser<Person, PersonVO>
    {
        public Person Parse(PersonVO source)
        {
            if (source == null)
                return new Person();

            var person = new Person
            {
                Id = source.Id,
                FirstName = source.FirstName,
                LastName = source.LastName,
                Address = source.Address,
                Gender = source.Gender
            };

            return person;
        }

        public PersonVO Parse(Person source)
        {
            if (source == null)
                return new PersonVO();

            var person = new PersonVO
            {
                Id = source.Id,
                FirstName = source.FirstName,
                LastName = source.LastName,
                Address = source.Address,
                Gender = source.Gender
            };

            return person;
        }

        public List<Person> ParseList(List<PersonVO> source)
        {
            if (source == null)
                return new List<Person>();

            return source.Select(item => Parse(item)).ToList();
        }

        public List<PersonVO> ParseList(List<Person> source)
        {
            if (source == null)
                return new List<PersonVO>();

            return source.Select(item => Parse(item)).ToList();
        }
    }
}
