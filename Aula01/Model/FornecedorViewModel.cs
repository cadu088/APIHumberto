using Aula01.Domain.Enum;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;


namespace Aula01.Model
{
	public class FornecedorViewModel
	{
		[JsonIgnore]
		public int Id { get; set; }

		[Required(ErrorMessage = "O campo {0} é obrigatório")]
		public string Nome { get;  set; }

		[Required(ErrorMessage = "O campo {0} é obrigatório")]
		public EnumTipoFornecedor TipoFornecedor { get;  set; }

		[Required(ErrorMessage = "O campo {0} é obrigatório")]
		public string Documento { get;  set; }
		[Required(ErrorMessage = "O campo {0} é obrigatório")]
		public bool Ativo { get;  set; }

		[SwaggerSchema(ReadOnly = true)]
		public string? Imagem { get; set; }

		public IFormFile file { get; set; }
	}
}
