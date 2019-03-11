using System;
using System.Collections.Generic;
using System.Threading;
using RestWithAspNETUdemy.Model;
using RestWithAspNETUdemy.Services.Interfaces;

namespace RestWithAspNETUdemy.Services.Implementattions
{
    public class PersonService : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }

            return persons;
        }

        private Person MockPerson(object i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Person Name " + i,
                LastName = "Person LastName " + i,
                Address = "Some Address " + i,
                Gender = "Male"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }

        public Person FindById(long id)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Hugo",
                LastName = "Ventura",
                Address = "Florisnópolis/SC, Brasil",
                Gender = "M"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }
    }
}
