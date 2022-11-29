using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01.Domain
{
    public class Categoria
    {

        protected Categoria()
        {

        }
        public Categoria(string nome, bool ativo)
        {
            NOME = nome;
            ATIVO = ativo;
        }

        public int ID_CATEGORIA { get; set; }
        public string NOME { get; set; }
        public bool ATIVO { get; set; }
    }
}
