using Aula01.Domain;
using Aula01.Model;
using AutoMapper;

namespace Aula01.Mapper
{
	public class ApplicationToDomain : Profile
	{
		public ApplicationToDomain()
		{

			CreateMap<ProdutoViewModel, Produto>()
			   .ConstructUsing(q => new Produto(q.NOME, q.PRECO, q.ESTOQUE, q.IMAGEM, q.ID_CATEGORIA, q.ID_FORNECEDOR));


			CreateMap<FornecedorViewModel, Fornecedor>()
				.ConstructUsing(f =>
				new Fornecedor(
					f.Nome, f.TipoFornecedor, f.Documento,f.Ativo, f.Imagem));

			CreateMap<CategoriaViewModel, Categoria>()
				.ConstructUsing(f =>
				new Categoria(
					f.Nome, f.Ativo));

			CreateMap<UsuarioViewModel, Usuario>()
			   .ConstructUsing(q => new Usuario(q.UserName, q.Password));
		}
	}
}

