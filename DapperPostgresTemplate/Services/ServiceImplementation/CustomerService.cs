using DapperPostgresTemplate.Data.RepositoryContracts;
using DapperPostgresTemplate.Domain.Common;
using DapperPostgresTemplate.Domain.Customer;
using DapperPostgresTemplate.Services.ServicContracts;

namespace DapperPostgresTemplate.Services.ServiceImplementation
{
    public class CustomerService: ICustomerService
    {
        private readonly IRepositoryManager _repositoryManager;

        public CustomerService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public async Task<ApiResponse<IEnumerable<Customer>>> GetCustomers()
        {
            var data = await _repositoryManager.customerRepository.GetCustomers();
            return new ApiResponse<IEnumerable<Customer>>(true,"success",data);
        }
    }
}
