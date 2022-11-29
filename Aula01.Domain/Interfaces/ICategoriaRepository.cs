using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01.Domain.Interfaces
{
	public interface ICategoriaRepository
	{
		public void Adicionar(Categoria categoria);
		public IEnumerable<Categoria> ObterTodasCategorias();
		public void Atualizar(Categoria categoria);
		public void Inativar(Categoria categoria);
		public void Ativar(Categoria categoria);
		public Categoria ObterCategoria(int id);

	}
}
