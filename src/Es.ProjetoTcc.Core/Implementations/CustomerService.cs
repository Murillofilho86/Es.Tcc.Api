using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using Es.ProjetoTcc.Contracts;
using Es.ProjetoTcc.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Es.ProjetoTcc.Implementations
{
    public class CustomerService : DomainService, ICustomerService
    {

        private readonly IRepository<Customer> _repository;

        public CustomerService(IRepository<Customer> repository)
        {
            _repository = repository;
        }

        public async Task<Customer> Create(Customer customer)
        {
            var _customer = _repository.FirstOrDefault(x => x.Id == customer.Id);

            if (_customer == null) throw new UserFriendlyException();

            return await _repository.InsertAsync(_customer);
        }

        public void Delete(int id)
        {
            var customer = _repository.FirstOrDefault(x => x.Id == id);

            if (customer == null) throw new UserFriendlyException();

            _repository.DeleteAsync(customer);
        }


        public IEnumerable<Customer> GetAllList()
        {
            throw new NotImplementedException();
            //return _repository.GetAllIncluding(x => x.Addresses);
        }

        public Customer GetById(int id)
        {
            return _repository.Get(id);
        }

        public void Update(Customer customer)
        {
            _repository.Update(customer);
        }

    }
}
