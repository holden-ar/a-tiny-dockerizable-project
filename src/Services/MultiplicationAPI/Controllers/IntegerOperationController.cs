using Microsoft.AspNetCore.Mvc;
using MultiplicationAPI.Commands;

namespace MultiplicationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IntegerOperationController : ControllerBase
    {

        [HttpPost]
        public int Multiply(MultiplicationCommand command)
        {
            return command.Op1 * command.Op2;
        }
    }
}
