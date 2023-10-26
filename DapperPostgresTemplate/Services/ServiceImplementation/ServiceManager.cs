using DapperPostgresTemplate.Data.RepositoryContracts;
using DapperPostgresTemplate.Services.ServicContracts;

namespace DapperPostgresTemplate.Services.ServiceImplementation
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<ICustomerService> _customerService;
        public ServiceManager(IRepositoryManager repositoryManager)
        {
            _customerService = new Lazy<ICustomerService>(()=> new CustomerService(repositoryManager));    
        }

        public ICustomerService customerService => _customerService.Value;
    }
}
