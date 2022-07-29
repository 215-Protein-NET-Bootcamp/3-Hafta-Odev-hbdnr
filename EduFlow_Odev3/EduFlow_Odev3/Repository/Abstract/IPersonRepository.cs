using EduFlow_Odev3.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EduFlow_Odev3.Repository
{
    public interface IPersonRepository
    {
        Task<Person> GetPerson(int id);
        Task<IEnumerable<Person>> GetAllCountries();
        Task AddPerson(Person person);
        Task<Person> UpdatePerson(Person person);
        Task<Person> DeletePerson(int id);
    }
}
