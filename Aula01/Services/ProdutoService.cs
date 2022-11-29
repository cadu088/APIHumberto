using Aula01.Domain;
using Aula01.Domain.Interfaces;
using Aula01.Model;
using AutoMapper;

namespace Aula01.Services
{
	public class ProdutoService : IProdutoService
	{

		private readonly IProdutoRepository _produtoRepository;
		private IMapper _mapper;

		public ProdutoService(IProdutoRepository produtoRepository, IMapper mapper)
		{
			_produtoRepository = produtoRepository;
			_mapper = mapper;
		}

		public async Task Adicionar(ProdutoViewModel produtoViewModel)
		{
			var imagemNome = Guid.NewGuid() + "_" + produtoViewModel.file.FileName;
			produtoViewModel.IMAGEM = imagemNome;


			if (!await UploadArquivo(produtoViewModel.file, imagemNome))
			{
				throw new ApplicationException("Erro ao subir a imagem");
			}

			_produtoRepository.Adicionar(_mapper.Map<Produto>(produtoViewModel));
		}

		public void Atualizar(ProdutoViewModel produto)
		{
			throw new NotImplementedException();
		}

		public ProdutoViewModel ObterProdutoId(int id)
		{
			return _mapper.Map<ProdutoViewModel>(_produtoRepository.ObterProdutoId(id));
		}

		public IEnumerable<ProdutoViewModel> ObterProdutoName(string name)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<ProdutoViewModel> ObterTodos()
		{
			return _mapper.Map<IEnumerable<ProdutoViewModel>>(_produtoRepository.ObterTodos());
		}

		public void Remover(int id)
		{
			throw new NotImplementedException();
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