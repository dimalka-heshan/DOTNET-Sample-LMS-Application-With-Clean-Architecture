using Microsoft.AspNetCore.Mvc;

namespace LMS.API.Controller
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class APIController:ControllerBase
    {

    }
}
