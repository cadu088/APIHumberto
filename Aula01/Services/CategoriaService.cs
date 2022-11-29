using Aula01.Domain;
using Aula01.Domain.Interfaces;
using Aula01.Interfaces;
using Aula01.Model;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Aula01.Services
{

	public class CategoriaService : ICategoriaService
	{
		private readonly ICategoriaRepository _categoriaRepository;
		private IMapper _mapper;


		public CategoriaService(ICategoriaRepository categoriaRepository,
			IMapper mapper)
		{
			_categoriaRepository = categoriaRepository;
			_mapper = mapper;
		}

		public async Task Adicionar(CategoriaViewModel categoria)
		{

			_categoriaRepository.Adicionar(_mapper.Map<Categoria>(categoria));
		}


		public void Atualizar(CategoriaViewModel categoria)
		{
			_categoriaRepository.Atualizar(_mapper.Map<Categoria>(categoria));
		}

		public void Ativar(CategoriaViewModel categoria)
		{
			_categoriaRepository.Ativar(_mapper.Map<Categoria>(categoria));
		}


		public void Inativar(CategoriaViewModel categoria)
		{
			_categoriaRepository.Inativar(_mapper.Map<Categoria>(categoria));
		}

		public CategoriaViewModel ObterPorId(int id)
		{
			return _mapper.Map<CategoriaViewModel>(_categoriaRepository.ObterCategoria(id));
			
		}
		public IEnumerable<CategoriaViewModel> ObterTodos()
		{
			return _mapper.Map<IEnumerable<CategoriaViewModel>>(_categoriaRepository.ObterTodasCategorias());
		}

	}
}
