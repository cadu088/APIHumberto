using Aula01.Domain;
using Aula01.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01.Interfaces
{
    public interface IUsuarioService
    {
        public Task<ActionResult<dynamic>> Autenticar(UsuarioViewModel usuario);
        public void Adicionar(UsuarioViewModel usuario);
        public void Atualizar(UsuarioViewModel usuario);
    }
}
