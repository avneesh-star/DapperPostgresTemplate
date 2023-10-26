using DapperPostgresTemplate.Domain.Common;
using DapperPostgresTemplate.Domain.Customer;
using System.Collections.Generic;

namespace DapperPostgresTemplate.Data.RepositoryContracts
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetCustomers();
    }
}
