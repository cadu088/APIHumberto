using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01.Domain.Interfaces
{
	public interface IFornecedorRepository
	{
		public void Adicionar(Fornecedor fornecedor);
		public IEnumerable<Fornecedor> ObterTodosFornecedores();
		public void Atualizar(Fornecedor fornecedor);
		public void Inativar(Fornecedor fornecedor);
		public void Ativar(Fornecedor fornecedor);
		public Fornecedor ObterFornecedor(int id);

	}
}
