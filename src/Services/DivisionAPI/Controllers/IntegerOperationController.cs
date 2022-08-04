using DivisionAPI.Commands;
using Microsoft.AspNetCore.Mvc;

namespace DivisionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IntegerOperationController : ControllerBase
    {

        [HttpPost]
        public decimal Divide(DivisionCommand command)
        {
            return command.Op1 / command.Op2;
        }
    }
}
