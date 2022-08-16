using FipeApi;
using Microsoft.AspNetCore.Mvc;
using System;

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
                Console.WriteLine("0");
                var fipeWS = new FipeWS();
                Console.WriteLine("1");
                var result = fipeWS.GetFipeInfo(fipeCode);
                Console.WriteLine("2");
                return Ok(result.VehiclePrice);
                Console.WriteLine("3");
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}
