using RestWithAspNETUdemy.Business.Interfaces;
using RestWithAspNETUdemy.Data.Converters;
using RestWithAspNETUdemy.Data.VO;
using RestWithAspNETUdemy.Model;
using RestWithAspNETUdemy.Repository.Generic;
using System.Collections.Generic;

namespace RestWithAspNETUdemy.Business.Implementattions
{
    public class PersonBusiness : IPersonBusiness
    {
        private IRepositoryBase<Person> _repository;
        private readonly PersonConverter _converter;
        
        public PersonBusiness(IRepositoryBase<Person> repository)
        {
            _repository = repository;
            _converter = new PersonConverter();
        }

        public PersonVO Create(PersonVO person)
        {
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Create(personEntity);
            return _converter.Parse(personEntity);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<PersonVO> FindAll()
        {
            return _converter.ParseList(_repository.FindAll());
        }

        public PersonVO FindById(long id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public PersonVO Update(PersonVO person)
        {
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Update(personEntity);
            return _converter.Parse(personEntity);
        }

        public bool Exists(long? id)
        {
            return _repository.Exists(id);
        }
    }
}
