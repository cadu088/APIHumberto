
using FluentValidation.Results;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Swashbuckle.AspNetCore.Annotations;


namespace Aula01.Model
{
	public class ProdutoViewModel
	{

		[JsonIgnore]
		public int ID_PRODUTO { get; set; }
		[Required(ErrorMessage = "O campo {0} é obrigatório")]
		[StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]

		public string NOME { get; set; }

		[Required(ErrorMessage = "O campo {0} é obrigatório")]
		public int ID_CATEGORIA { get; set; }

		[Required(ErrorMessage = "O campo {0} é obrigatório")]
		public int ID_FORNECEDOR { get; set; }

		[Range(0, 1000, ErrorMessage = "Valor de {0} deve entre {1} e {2}.")]

		[Required(ErrorMessage = "O campo {0} é obrigatório")]
		public decimal PRECO { get; set; }

		[Range(0, 1000, ErrorMessage = "Valor de {0} deve entre {1} e {2}.")]

		[Required(ErrorMessage = "O campo {0} é obrigatório")]
		public int ESTOQUE { get; set; }

		[SwaggerSchema(ReadOnly = true)]
		public string? IMAGEM { get; set; }

		public IFormFile file { get; set; }



	}
}
