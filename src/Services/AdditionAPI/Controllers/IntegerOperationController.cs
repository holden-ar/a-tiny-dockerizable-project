
using AdditionAPI.Commands;
using Microsoft.AspNetCore.Mvc;

namespace AdditionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IntegerOperationController : ControllerBase
    {
        [HttpPost]
        public int Add(AdditionCommand command)
        {
            return command.Op1 + command.Op2;
        }

        [HttpGet]
        public string Get()
        {
            return "AddtionAPI v1";
        }
    }
}
