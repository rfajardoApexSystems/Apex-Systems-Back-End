using Microsoft.AspNetCore.Mvc;

namespace BackEndAssignment.Controllers
{
    [ApiController]
    //Should use api versioning for the controller ignore change it if needed.
    [Route("api/[controller]")]
    public class BaseApiController : Controller
    {
        
    }
}
