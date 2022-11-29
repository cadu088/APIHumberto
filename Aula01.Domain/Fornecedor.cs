using Aula01.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01.Domain
{
	public class Fornecedor
	{
		protected Fornecedor()
        {

        }
		public Fornecedor(string nome, EnumTipoFornecedor tipoFornecedor, string documento, bool ativo, string imagem)
		{
			NOME = nome;
			TIPO = tipoFornecedor;
			DOCUMENTO = documento;
			ATIVO = ativo;
			IMAGEM = imagem;
		}

		public int ID_FORNECEDOR { get; set; }
		public string NOME { get; set; }
		public EnumTipoFornecedor TIPO { get; set; }
		public string DOCUMENTO { get; set; }
		public bool ATIVO { get; set; }
		public string IMAGEM { get; set; }
	}
}
