using Aula01.Domain;
using Aula01.Domain.Interfaces;
using Aula01.Interfaces;
using Aula01.Model;
using Aula01.Token;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Aula01.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private IMapper _mapper;

        public UsuarioService(IUsuarioRepository usuarioRepository, IMapper mapper)
        {
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
        }

        //public Usuario Autenticar(UsuarioViewModel usuario);
        //public void Adicionar(UsuarioViewModel usuario);
        //public void Atualizar(UsuarioViewModel usuario);
        public async Task<ActionResult<dynamic>> Autenticar([FromBody] UsuarioViewModel usuarioViewModel)
        {
            // Recupera o usuário
            var buscaUsuario = _usuarioRepository.Autenticar(_mapper.Map<Usuario>(usuarioViewModel));

            // Verifica se o usuário existe
            if (buscaUsuario == null)
                return new { message = "Usuário não existe e/ou Senha inválida!" };

            // Gera o Token
            var token = TokenService.GenerateToken(buscaUsuario);

            // Oculta a senha
            buscaUsuario.Password = "";

            // Retorna os dados
            return new
            {
                usuario = buscaUsuario,
                token = token
            };
        }

        public void Adicionar(UsuarioViewModel usuarioViewModel)
        {

            _usuarioRepository.Adicionar(_mapper.Map<Usuario>(usuarioViewModel));
        }

        public void Atualizar(UsuarioViewModel usuario)
        {
            _usuarioRepository.Atualizar(_mapper.Map<Usuario>(usuario));
        }
    }
}
