using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pdc_api.Model;
using pdc_api.Services;

namespace pdc_api.Controllers
{
    [Route("api/horoscopo")]
    [ApiController]
    public class HoroscopoController : ControllerBase
    {
        [HttpGet]
        [Route("sorte-do-dia")]
        public IActionResult SorteDoDia(string username)
        {
            var res = new BaseResponse();

            var user = UsuarioService.BuscarUsuario(username);
            if (user == null)
                return BadRequest(res.NotFoundResponse());

            var sorte = HoroscopoService.SorteDoDia(username);
            return Ok(res.SuccessResponse(sorte));
        }
    }
}
