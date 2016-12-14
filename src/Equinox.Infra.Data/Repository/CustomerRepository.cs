﻿using System.Linq;
using Equinox.Domain.Interfaces;
using Equinox.Domain.Models;
using Equinox.Infra.Data.Context;

namespace Equinox.Infra.Data.Repository
{
    public class CustomerRepository : Repository<Customer>,  ICustomerRepository
    {
        public CustomerRepository(EquinoxContext context)
            :base(context)
        {

        }       

        public Customer GetByEmail(string email)
        {
            return Find(c => c.Email == email).FirstOrDefault();
        }
    }
}