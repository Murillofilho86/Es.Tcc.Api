using Abp.Domain.Services;
using Es.ProjetoTcc.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Es.ProjetoTcc.Contracts
{
    public interface ICustomerService : IDomainService
    {
        IEnumerable<Customer> GetAllList();
        Task<Customer> Create(Customer customer);
        void Update(Customer customer);
        void Delete(int id);
    }
}
