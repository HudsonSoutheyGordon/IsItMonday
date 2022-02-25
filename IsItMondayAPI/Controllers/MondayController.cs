using Microsoft.AspNetCore.Mvc;
using IsItMondayAPI.Services;

namespace IsItMondayAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/")]
    public class MondayController : ControllerBase
    {
        private readonly MondayServices _mondayServices;
        public MondayController(MondayServices mondayServices) =>
            _mondayServices = mondayServices;

        [HttpGet]
        public ActionResult<bool> GetIsItMonday()
        {
            return _mondayServices.IsItMonday();
        }
    }
}
