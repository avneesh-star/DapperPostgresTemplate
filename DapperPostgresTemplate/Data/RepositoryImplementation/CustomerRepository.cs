using Dapper;
using DapperPostgresTemplate.Data.RepositoryContracts;
using DapperPostgresTemplate.Domain.Common;
using DapperPostgresTemplate.Domain.Customer;

namespace DapperPostgresTemplate.Data.RepositoryImplementation
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DapperContext _dapperContext;

        public CustomerRepository(DapperContext dapperContext)
        {
            _dapperContext = dapperContext;
        }

        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            string sql = "SELECT * FROM public.\"Usp_tblCustomersGet\"(0);";
            using (var connection = _dapperContext.GetConnection())
            {
                var customer = await connection.QueryAsync<Customer>(sql);
                return customer;
            }
        }
    }
}
