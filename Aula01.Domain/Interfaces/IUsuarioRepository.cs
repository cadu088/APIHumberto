using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01.Domain.Interfaces
{
    public interface IUsuarioRepository
    {
        public Usuario Autenticar(Usuario usuario);
        public void Adicionar(Usuario usuario);
        public void Atualizar(Usuario usuario);
    }
}
