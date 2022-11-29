using Aula01.Domain;
using Aula01.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01.Interfaces
{
	public interface IFornecedorService
	{
		public Task Cadastrar([FromForm] FornecedorViewModel fornecedor);
		public IEnumerable<FornecedorViewModel> ObterTodos();
		public void Atualizar(FornecedorViewModel fornecedor);
		public void Inativar(FornecedorViewModel fornecedor);
		public void Ativar(FornecedorViewModel fornecedor);
		public FornecedorViewModel ObterPorId(int id);

	}
}
