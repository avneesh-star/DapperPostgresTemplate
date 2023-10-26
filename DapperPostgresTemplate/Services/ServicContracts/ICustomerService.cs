using DapperPostgresTemplate.Domain.Common;
using DapperPostgresTemplate.Domain.Customer;

namespace DapperPostgresTemplate.Services.ServicContracts
{
    public interface ICustomerService
    {
        Task<ApiResponse<IEnumerable<Customer>>> GetCustomers();
    }

}
