using Aula01.Domain.Enum;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Aula01.Model
{
	public class CategoriaViewModel
	{
		[JsonIgnore]
		public int Id { get; set; }

		[Required(ErrorMessage = "O campo {0} é obrigatório")]
		public string Nome { get;  set; }

		[Required(ErrorMessage = "O campo {0} é obrigatório")]
		public bool Ativo { get;  set; }
	}
}
