using Microsoft.AspNetCore.Mvc;
using SubstractionAPI.Commands;

namespace SubstractionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IntegerOperationController : ControllerBase
    {

        [HttpPost]
        public int Subs(SubstractionCommand command)
        {
            return command.Op1 - command.Op2;
        }
    }
}
