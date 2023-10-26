namespace DapperPostgresTemplate.Domain.Common
{
    public record ApiResponse<T>(bool success, string message, T data)
    {
        public ApiResponse() : this(default, default, default)
        {
        }
    }
    
}
