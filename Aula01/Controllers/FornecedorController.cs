using Aula01.Domain;
using Aula01.Domain.Interfaces;
using Aula01.Interfaces;
using Aula01.Model;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Aula01.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class FornecedorController : Controller
	{
		private readonly IFornecedorService _fornecedorService;


		public FornecedorController(IFornecedorService fornecedorService)
		{
			_fornecedorService = fornecedorService;
		}

		[Route("Cadastrar")]
		[HttpPost]
		public async Task<IActionResult> Cadastrar([FromForm] FornecedorViewModel fornecedor)
		{
            try
            {
				_fornecedorService.Cadastrar(fornecedor);
				return Ok(new { success = true, mensagem = "Inserido com sucesso" });
			}catch (Exception ex)
            {
				return BadRequest(new { success = false, mensagem = ex.Message });
			}

			
		}

		[Route("Atualizar")]
		[HttpPut]
		public IActionResult Atualizar(FornecedorViewModel fornecedor)
		{
			_fornecedorService.Atualizar(fornecedor);
			return Ok();
		}

		[Route("Ativar")]
		[HttpPut]
		public IActionResult Ativar(FornecedorViewModel fornecedor)
		{
			_fornecedorService.Ativar(fornecedor);
			return Ok();
		}

		[Route("Inativar")]
		[HttpPut]
		public IActionResult Inativar(FornecedorViewModel fornecedor)
		{
			_fornecedorService.Inativar(fornecedor);
			return Ok();
		}

		[Route("ObterPorId")]
		[HttpGet]
		public IActionResult ObterPorId(int id)
		{
			var pesquisa = _fornecedorService.ObterPorId(id);
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
					listaProdutos = _fornecedorService.ObterTodos()
				}
				); 
		}
	}
}
