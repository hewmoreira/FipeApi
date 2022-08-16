using Fipe.Repositories;
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
        [HttpGet("code/{fipeCode}")]
        public IActionResult GetFipeCode([FromRoute] string fipeCode)
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

        /// <summary>
        /// Return the car code price informed
        /// </summary>
        /// <param name="id">Car Id</param>
        /// <returns>A car value</returns>
        [HttpGet("{id}")]
        public IActionResult GetId([FromRoute] int id)
        {
            try
            {
                var price = new VehiclePriceMocked().SearchValue(id);

                return Ok(price);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
