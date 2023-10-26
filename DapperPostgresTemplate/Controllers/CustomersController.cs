using DapperPostgresTemplate.Data.RepositoryContracts;
using DapperPostgresTemplate.Domain.Common;
using DapperPostgresTemplate.Services.ServicContracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace DapperPostgresTemplate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
       
        private readonly IServiceManager _serviceManager;
        public CustomersController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetCustomers()
        {
            try
            {
                var data = await _serviceManager.customerService.GetCustomers();
                return  Ok(data);
            }
            catch (Exception ex)
            {
                return Ok(new ApiResponse<string>(false, ex.Message,ex.ToString()));
            }
        }
    }
}
