using Aula01.Domain;
using Aula01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01.Services
{
	public interface ICategoriaService
	{
		public Task Adicionar(CategoriaViewModel categoria);
		public IEnumerable<CategoriaViewModel> ObterTodos();
		public void Atualizar(CategoriaViewModel categoria);
		public void Inativar(CategoriaViewModel categoria);
		public void Ativar(CategoriaViewModel categoria);
		public CategoriaViewModel ObterPorId(int id);

	}
}
