﻿using RestWithAspNETUdemy.Business.Interfaces;
using RestWithAspNETUdemy.Model;
using RestWithAspNETUdemy.Repository.Generic;
using System.Collections.Generic;

namespace RestWithAspNETUdemy.Business.Implementattions
{
    public class PersonBusiness : IPersonBusiness
    {
        private IRepositoryBase<Person> _repository;
        
        public PersonBusiness(IRepositoryBase<Person> repository)
        {
            _repository = repository;
        }
        public Person Create(Person person)
        {
            return _repository.Create(person);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<Person> FindAll()
        {
            return _repository.FindAll();
        }

        public Person FindById(long id)
        {
            return _repository.FindById(id);
        }

        public Person Update(Person person)
        {
            return _repository.Update(person);
        }
    }
}
