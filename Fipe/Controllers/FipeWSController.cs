using FipeApi;
using Microsoft.AspNetCore.Mvc;

namespace Fipe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FipeWSController : ControllerBase
    {
        /// <summary>
        /// Return the car code price informed
        /// </summary>
        /// <param name="fipeCode">Car FIPE Code</param>
        /// <returns>A car value</returns>
        [HttpGet("{fipeCode}")]
        public IActionResult Get([FromRoute] string fipeCode)
        {
            try
            {
                var fipeWS = new FipeWS();
                var result = fipeWS.GetFipeInfo(fipeCode);
                return Ok(result.VehiclePrice);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
