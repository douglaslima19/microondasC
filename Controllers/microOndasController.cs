using Microsoft.AspNetCore.Mvc;
using microOndas.Service;
using microOndas.Exceptions;
using System.Runtime.Serialization;

namespace microOndas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MicroOndasController : ControllerBase
    {
        private readonly MicroService _microService;

        public MicroOndasController(MicroService microService)
        {
            _microService = microService;
        }

        [HttpPost("start")]
        public IActionResult StartMicroOndas(int seconds, int power = 10)
        {
            try
            {
                var result = _microService.InicioAquecimento(seconds, power);
                return Ok(result);
            }
            catch (MicroOndasException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
            catch (Exception)
            {
                return StatusCode(500, new { message = "Internal server error." });
            }
        }

        [HttpPost("InicioRapido")]
        public IActionResult InicioRapMicroOndas()
        {
            try
            {
                var result = _microService.InicioRapMicroOndas();
                return Ok(result);
            }
            catch (MicroOndasException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
            catch (Exception)
            {
                return StatusCode(500, new { message = "Internal server error." });
            }
        }

        [HttpPost("pause")]
        public IActionResult PauseMicroOndas()
        {
            try
            {
                var result = _microService.PauseMicroOndas();
                return Ok(result);
            }
            catch (MicroOndasException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
            catch (Exception)
            {
                return StatusCode(500, new { message = "Internal server error." });
            }
        }

        [HttpPost("cancel")]
        public IActionResult CancelAquecimento()
        {
            try
            {
                var result = _microService.CancelAquecimento();
                return Ok(result);
            }
            catch (MicroOndasException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
            catch (Exception)
            {
                return StatusCode(500, new { message = "Internal server error." });
            }
        }

        [HttpPost("Pipoca")]
        public IActionResult StartPipoca()
        {
            int segundos = 180;
            int potencia = 7;
            try
            {
                var result = _microService.InicioAquecimento(segundos, potencia);
                return Ok(result);
            }
            catch (MicroOndasException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
            catch (Exception)
            {
                return StatusCode(500, new { message = "Internal server error." });
            }
        }
        [HttpPost("Leite")]
        public IActionResult StartLeite()
        {
            int segundos = 360;
            int potencia = 5;
            try
            {
                var result = _microService.InicioAquecimento(segundos, potencia);
                return Ok(result);
            }
            catch (MicroOndasException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
            catch (Exception)
            {
                return StatusCode(500, new { message = "Internal server error." });
            }
        }
        [HttpPost("Carne")]
        public IActionResult StartCarne()
        {
            int segundos = 840;
            int potencia = 4;
            try
            {
                var result = _microService.InicioAquecimento(segundos, potencia);
                return Ok(result);
            }
            catch (MicroOndasException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
            catch (Exception)
            {
                return StatusCode(500, new { message = "Internal server error." });
            }
        }

        [HttpPost("frango")]
        public IActionResult StartFrango()
        {
            int segundos = 480;
            int potencia = 7;
            try
            {
                var result = _microService.InicioAquecimento(segundos, potencia);
                return Ok(result);
            }
            catch (MicroOndasException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
            catch (Exception)
            {
                return StatusCode(500, new { message = "Internal server error." });
            }
        }

        [HttpPost("feijao")]
        public IActionResult StartFeijao()
        {
            int segundos = 480;
            int potencia = 9;
            try
            {
                var result = _microService.InicioAquecimento(segundos, potencia);
                return Ok(result);
            }
            catch (MicroOndasException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
            catch (Exception)
            {
                return StatusCode(500, new { message = "Internal server error." });
            }
        }
    }

  
}
