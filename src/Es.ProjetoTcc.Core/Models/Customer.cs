using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Es.ProjetoTcc.Models
{
    public class Customer : FullAuditedEntity
    {
        //  private readonly IList<Address> _addresses;

        public Customer(
          string email,
          string firstName,
          string lastName,
           DateTime birthDate,
          string document,
           string phone
           )
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            BirthDate = birthDate;
            Document = document;
            Phone = phone;
          //  _addresses = new List<Address>();
        }

        public int CustomerId { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; private set; }
        public string Phone { get; private set; }
        public string DriversLicense { get; private set; }
        public string Document { get; set; }

        public int PlanId { get; set; }
        public Plan Plan { get; private set; }


        //public IReadOnlyCollection<Address> Addresses => _addresses.ToArray();


        //public void AddAddresses(Address address)
        //{
        //    _addresses.Add(address);
        //}

        //public override string ToString()
        //{
        //    return Name.ToString();
        //}
    }

}
