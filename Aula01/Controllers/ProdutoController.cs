using Aula01.Domain;
using Aula01.Domain.Interfaces;
using Aula01.Model;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Aula01.Services;

namespace Aula01.Controllers
{
	[Authorize]
	[ApiController]
	[Route("[controller]")]
	public class ProdutoController : Controller
	{
		private readonly IProdutoService _produtoService;


		public ProdutoController(IProdutoService produtoRepository)
		{
			_produtoService = produtoRepository;
		}

		
		[HttpPost]
		public async Task<IActionResult> Cadastrar([FromForm] ProdutoViewModel produtoViewModel)
		{
			try
			{
				if (!ModelState.IsValid) return BadRequest(ModelState);

				await _produtoService.Adicionar(produtoViewModel);

				return Ok(new { success = true, mensagem = "Inserido com sucesso" });
			}
			catch (Exception ex)
			{

				return BadRequest(new { success = false, mensagem = ex.Message });
			}
		}

		[HttpPut]
		public IActionResult Atualizar()
		{
			return Ok();
		}

		[HttpGet]
		public IActionResult ObterPorId(int id)
		{
			var pesquisa = _produtoService.ObterProdutoId(id);
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
					listaProdutos = _produtoService.ObterTodos()
				}
				);
		}

	}
}
