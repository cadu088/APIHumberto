using Aula01.Domain;
using Aula01.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01.Data.Repository
{
	public class ProdutoRepository : IProdutoRepository
	{
		private readonly GestaoContext _context;

		public ProdutoRepository(GestaoContext context)
		{
			_context = context;
		}

		public void Adicionar(Produto produto)
		{
			_context.Produtos.Add(produto);
			Gravar();
		} 

		public IEnumerable<Produto> ObterTodos()
		{
			return _context.Produtos.ToList();
		}

		public void Atualizar(Produto produto)
		{
			_context.Produtos.Update(produto);
			Gravar();
		}

		public Produto ObterProdutoId(int id)
		{
			return _context.Produtos.Where(p => p.ID_PRODUTO == id).FirstOrDefault();
		}

		public IEnumerable<Produto> ObterProdutoName(string name)
		{
			return _context.Produtos.Where(p => p.NOME == name);
		}

		

		public void Remover(int id)
		{
			_context.Remove(id);
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
