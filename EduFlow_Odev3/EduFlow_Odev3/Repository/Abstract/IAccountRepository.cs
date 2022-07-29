using EduFlow_Odev3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduFlow_Odev3.Repository
{
    public interface IAccountRepository
    {
        Task<Account> GetAccount(int id);
        Task<IEnumerable<Account>> GetAllCountries();
        Task AddAccount(Account account);
        Task<Account> UpdateAccount(Account account);
        Task<Account> DeleteAccount(int id);
    }
}
