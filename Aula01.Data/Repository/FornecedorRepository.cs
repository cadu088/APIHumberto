using Aula01.Domain;
using Aula01.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01.Data.Repository
{
	public class FornecedorRepository : IFornecedorRepository
	{ //operações > Interfaces
		private readonly GestaoContext _context;

		public FornecedorRepository(GestaoContext context)
		{
			_context = context;
		}
		public void Adicionar(Fornecedor fornecedor)
		{
			_context.Add(fornecedor);
			Gravar();
		}
		public IEnumerable<Fornecedor> ObterTodosFornecedores()
		{
			return _context.Fornecedor.ToList();
		}

		public void Ativar(Fornecedor fornecedor)
		{
			_context.Fornecedor.Update(fornecedor);
			Gravar();
		}

		public void Atualizar(Fornecedor fornecedor)
		{
			_context.Fornecedor.Update(fornecedor);
			Gravar();
		}

		public void Inativar(Fornecedor fornecedor)
		{
			_context.Fornecedor.Update(fornecedor);
			Gravar();
		}

		public Fornecedor ObterFornecedor(int id)
		{
			return _context.Fornecedor.Where(p => p.ID_FORNECEDOR == id).FirstOrDefault();
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
