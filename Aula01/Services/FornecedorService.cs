using Aula01.Domain;
using Aula01.Domain.Interfaces;
using Aula01.Interfaces;
using Aula01.Model;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Aula01.Service
{

	public class FornecedorService : IFornecedorService
	{
		private readonly IFornecedorRepository _fornecedorRepository;
		private IMapper _mapper;
		public FornecedorService(IFornecedorRepository fornecedorService, IMapper mapper)
		{
			_fornecedorRepository = fornecedorService;
			_mapper = mapper;
		}

		public async Task Cadastrar([FromForm] FornecedorViewModel fornecedor)
		{
			var imagemNome = Guid.NewGuid() + "_" + fornecedor.file.FileName;
			fornecedor.Imagem = imagemNome;


			if (!await UploadArquivo(fornecedor.file, imagemNome))
			{
				throw new ApplicationException("Erro ao subir a imagem");
			}

			_fornecedorRepository.Adicionar(_mapper.Map<Fornecedor>(fornecedor));
		}

		public void Atualizar(FornecedorViewModel fornecedor)
		{
			_fornecedorRepository.Atualizar(_mapper.Map<Fornecedor>(fornecedor));
		}

		public void Ativar(FornecedorViewModel fornecedor)
		{
			_fornecedorRepository.Ativar(_mapper.Map<Fornecedor>(fornecedor));
		}

		public void Inativar(FornecedorViewModel fornecedor)
		{
			_fornecedorRepository.Inativar(_mapper.Map<Fornecedor>(fornecedor));
		}

		public FornecedorViewModel ObterPorId(int id)
		{
			return _mapper.Map<FornecedorViewModel>(_fornecedorRepository.ObterFornecedor(id));
		
		}
		public IEnumerable<FornecedorViewModel> ObterTodos()
		{
			return _mapper.Map<IEnumerable<FornecedorViewModel>>(_fornecedorRepository.ObterTodosFornecedores());
				
		}

		private async Task<bool> UploadArquivo(IFormFile arquivo, string imgNome)
		{

			if (arquivo == null || arquivo.Length == 0)
			{
				return false;
			}

			var path = Path.Combine(Directory.GetCurrentDirectory(), "Content/Images", imgNome);


			using (var stream = new FileStream(path, FileMode.Create))
			{
				await arquivo.CopyToAsync(stream);
			}

			return true;
		}
	}
}
