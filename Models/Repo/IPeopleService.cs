using ListOfPeople.Models.Entities;
using ListOfPeople.Models.View;

namespace ListOfPeople.Models.Repo
{
    public interface IPeopleService
    {
        Person Add(CreatePersonViewModel person);
        List<Person> All();
        List<Person> Search(string search);
        Person FindById(int id);
        bool Remove(int id);
    }
}
