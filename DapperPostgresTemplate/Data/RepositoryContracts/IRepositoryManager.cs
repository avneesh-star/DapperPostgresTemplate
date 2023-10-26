namespace DapperPostgresTemplate.Data.RepositoryContracts
{
    public interface IRepositoryManager
    {
        public ICustomerRepository customerRepository { get;  }
    }
}
