using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectWebHttpClient.Service;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebHttpClient.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ServiceCep _serviceCep;

        public WeatherForecastController(ServiceCep serviceCep)
        {
            _serviceCep = serviceCep;
            
        }

        [HttpGet]
        public async Task<IActionResult> Get(string cep)
        {
            var GetCliente = await _serviceCep.RecuperandoCep(cep); 

            return Ok(GetCliente); 
        }
    }
}
