using Aula01.Domain.Validations;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01.Domain
{
	public class Produto
	{
		protected Produto()
        {

        }
		public Produto(string nome, decimal preco, int estoque, string imagem, int id_categoria, int id_fornecedor)
		{

			NOME = nome;
			PRECO = preco;
			ESTOQUE = estoque;
			IMAGEM = imagem;
			ID_CATEGORIA = id_categoria;
			ID_FORNECEDOR = id_fornecedor;
		}

		public int ID_PRODUTO { get; set; }
		public string NOME { get; set; }
		public int ID_CATEGORIA { get; set; }
		public int ID_FORNECEDOR { get; set; }
		public decimal PRECO { get; set; }
		public int ESTOQUE { get; set; }
		public string IMAGEM { get; set; }

	} 
}
