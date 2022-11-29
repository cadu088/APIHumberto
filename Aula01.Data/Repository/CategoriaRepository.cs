using Aula01.Domain;
using Aula01.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01.Data.Repository
{
	public class CategoriaRepository : ICategoriaRepository
	{ //operações > Interfaces
		private readonly GestaoContext _context;

		public CategoriaRepository(GestaoContext context)
		{
			_context = context;
		}
		public void Adicionar(Categoria categoria)
		{
			_context.Add(categoria);
			Gravar();
		}
		public IEnumerable<Categoria> ObterTodasCategorias()
		{
			return _context.Categoria.ToList();
		}

		public void Ativar(Categoria categoria)
		{
			_context.Categoria.Update(categoria);
			Gravar();
		}

		public void Atualizar(Categoria categoria)
		{
			_context.Categoria.Update(categoria);
			Gravar();
		}

		public void Inativar(Categoria categoria)
		{
			_context.Categoria.Update(categoria);
			Gravar();
		}

		public Categoria ObterCategoria(int id)
		{
			return _context.Categoria.Where(p => p.ID_CATEGORIA == id).FirstOrDefault();
		}

		private void Gravar()
		{
			_context.SaveChanges();
		}

		public void Dispose()
		{
			_context.Dispose();
		}

	}
}
