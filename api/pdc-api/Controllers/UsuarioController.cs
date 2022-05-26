using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pdc_api.Model;
using pdc_api.Services;
using System.Net;

namespace pdc_api.Controllers
{
    [Route("api/usuarios")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        /// <summary>
        /// Busca e retorna o usuário
        /// </summary>
        /// <param name="username">Nick do usuário cadastrado</param>
        /// <returns>Usuário cadastrado ou erro se o usuário não existir</returns>
        [HttpGet]
        public IActionResult Identificar(string username)
        {
            var user = UsuarioService.BuscarUsuario(username);
            var res = new BaseResponse(user);
            return user != null ? Ok(res.SuccessResponse()) : NotFound(res.NotFoundResponse());
        }

        /// <summary>
        /// Cadastra um usuário
        /// </summary>
        /// <param name="usuario">Usuário contendo o username e o signo</param>
        /// <returns>Sucesso do cadastro ou erro se o usuário já existir</returns>
        [HttpPost]
        public IActionResult Cadastrar(Usuario usuario)
        {
            var success = UsuarioService.CadastrarUsuario(usuario);
            var res = new BaseResponse();
            return success ? Ok(res.SuccessResponse()) : BadRequest(res.ErrorResponse("Usuário já cadastrado."));
        }
    }
}
