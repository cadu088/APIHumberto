using Aula01.Domain;
using Aula01.Domain.Interfaces;
using Aula01.Model;
using Aula01.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Aula01.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class CategoriaService : Controller
	{
		private readonly ICategoriaService _categoriaService;


		public CategoriaService(ICategoriaService categoriaService)
		{
			_categoriaService = categoriaService;
		}

		[Route("Cadastrar")]
		[HttpPost]
		public async Task<IActionResult> Cadastrar(CategoriaViewModel categoria)
		{
            try
            {
				await _categoriaService.Adicionar(categoria);
				return Ok(new { success = true, mensagem = "Inserido com sucesso" });

			}
			catch (Exception ex)
            {
				return BadRequest(new { success = false, mensagem = ex.Message });
			}
		}


		[Route("Atualizar")]
		[HttpPut]
		public IActionResult Atualizar(CategoriaViewModel categoria)
		{
			_categoriaService.Atualizar(categoria);
			return Ok();
		}

		[Route("Ativar")]
		[HttpPut]
		public IActionResult Ativar(CategoriaViewModel categoria)
		{
			_categoriaService.Ativar(categoria);
			return Ok();
		}

		[Route("Inativar")]
		[HttpPut]
		public IActionResult Inativar(CategoriaViewModel categoria)
		{
			_categoriaService.Inativar(categoria);
			return Ok();
		}

		[Route("ObterPorId")]
		[HttpGet]
		public IActionResult ObterPorId(int id)
		{
			var pesquisa = _categoriaService.ObterPorId(id);
			if (pesquisa == null) return NotFound();
			return Ok(
				new
				{
					success = true,
					produto = pesquisa
				}
				);
		}
		[Route("ObterTodos")]
		[HttpGet]
		public IActionResult ObterTodos()
		{
			return Ok(
				new
				{
					success = true,
					listaProdutos = _categoriaService.ObterTodos()
				}
				);
		}

	}
}
