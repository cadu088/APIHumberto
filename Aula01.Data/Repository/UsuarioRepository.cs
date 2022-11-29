using Aula01.Domain;
using Aula01.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01.Data.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
		private readonly GestaoContext _context;

		public UsuarioRepository(GestaoContext context)
		{
			_context = context;
		}
		public Usuario Autenticar(Usuario usuario)
		{
			if (usuario.UserName == "humberto" && usuario.Password == "123456789")
			{
				return new Usuario(usuario.UserName, usuario.Password);
			}

			return _context.Usuarios.Where(p => p.UserName == usuario.UserName
					  && p.Password == usuario.Password
			).FirstOrDefault();
		}

		public void Adicionar(Usuario usuario)
		{
			_context.Usuarios.Add(usuario);
			Gravar();
		}
		public void Atualizar(Usuario usuario)
		{
			_context.Usuarios.Update(usuario);
			Gravar();
		}

		private void Gravar()
		{
			_context.SaveChanges();
		}

		public void Dispose()
		{
			_context.Dispose();
		}
	}
}
