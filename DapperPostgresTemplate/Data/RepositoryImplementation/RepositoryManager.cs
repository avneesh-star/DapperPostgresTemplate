using DapperPostgresTemplate.Data.RepositoryContracts;

namespace DapperPostgresTemplate.Data.RepositoryImplementation
{
    public class RepositoryManager : IRepositoryManager
    {

        private readonly Lazy<ICustomerRepository> _customerRepository;
        public RepositoryManager(DapperContext dapperContext)
        {
            _customerRepository = new Lazy<ICustomerRepository>(() => new CustomerRepository(dapperContext));
        }

        public ICustomerRepository customerRepository => _customerRepository.Value;
    }
}
