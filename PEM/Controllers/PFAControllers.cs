using Microsoft.AspNetCore.Mvc;
using PEM.Service.Helpers.Clients;

namespace PEM.Controllers
{
    public class PFAControllers : ControllerBase
    {
        private readonly ILoginClient loginClient;

        public PFAControllers(ILoginClient loginClient)
        {
            this.loginClient = loginClient;
        }

        public IActionResult Get()
        {
            var result = loginClient.GetAllPFATypes();
            return Ok(result);
        }
    }
}
