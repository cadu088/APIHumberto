using Aula01.Domain;
using Aula01.Domain.Interfaces;
using Aula01.Interfaces;
using Aula01.Model;
using Aula01.Token;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Aula01.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioRepository)
        {
            _usuarioService = usuarioRepository;
        }

        [HttpPost]
        [Route("login")]
        public async Task<ActionResult<dynamic>> Authenticate([FromBody] UsuarioViewModel usuarioViewModel)
        {
            try
            {
                ActionResult<dynamic>  result = _usuarioService.Autenticar(usuarioViewModel);

                return result;
            }
            catch (Exception ex)
            {
                return BadRequest(new { success = false, mensagem = ex.Message });
            }
        }

        [Route("Cadastrar")]
        [HttpPost]
        public async Task<IActionResult> Cadastrar(UsuarioViewModel usuarioViewModel)
        {

            _usuarioService.Adicionar(usuarioViewModel);
            return Ok(new { success = true, mensagem = "Inserido com sucesso" });
        }

        [Route("Atualizar")]
        [HttpPut]
        public IActionResult Atualizar(UsuarioViewModel usuario)
        {
            _usuarioService.Atualizar(usuario);
            return Ok();
        }
    }
}
