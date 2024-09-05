﻿using ListOfPeople.Models.Entities;
using ListOfPeople.Models.Repo;
using ListOfPeople.Models;
using ListOfPeople.Models.View;


namespace ListOfPeople.Models
{
        public class PeopleService : IPeopleService
        {
            private readonly IPeopleRepo _peopleRepo;

            public PeopleService(IPeopleRepo peopleRepo)
            {
                _peopleRepo = peopleRepo;

            }
            public Person Add(CreatePersonViewModel person)
            {

                var newPerson = new Person(person.Name, person.PhoneNumber, person.City);
                return _peopleRepo.Create(newPerson);
                throw new NotImplementedException();
            }
            public List<Person> All()
            {
                return _peopleRepo.Read();
                throw new NotImplementedException();
            }
            public Person FindById(int id)
            {
                return _peopleRepo.Read(id);
                throw new NotImplementedException();
            }
            public bool Edit(int id, CreatePersonViewModel person)
            {
                var existingPerson = FindById(id);
                if (existingPerson != null)
                {
                    existingPerson.Name = person.Name;
                    existingPerson.PhoneNumber = person.PhoneNumber;
                    existingPerson.City = person.City;
                    return _peopleRepo.Update(existingPerson);
                }
                return false;
                throw new NotImplementedException();
            }
            public bool Remove(int id)
            {
                var person = FindById(id);
                if (person != null)
                {
                    return _peopleRepo.Delete(person);
                }
                return false;
                throw new NotImplementedException();
            }

            public List<Person> Search(string search)
            {
                return _peopleRepo.Read().Where(p => p.Name.Contains(search) || p.City.Contains(search)).ToList();
                throw new NotImplementedException();
            }
        }
 }
