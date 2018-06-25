using System;
using System.Collections.Generic;

namespace CursoMVCAbril.Domain.Entities
{
    public class Cliente
    {
        public Cliente()
        {
            //Inicializando o Global unique identity
            ClienteId = Guid.NewGuid();
            Enderecos = new List<Endereco>();
        }

        public Guid ClienteId { get; set; }

        public string Nome { get; set; }

        public string  Email { get; set; }

        public string CPF { get; set; }

        public DateTime DataNascimento { get; set; }

        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

        //virtual - habilita o lazi load que só ira buscar a colecao de enderecos quando
        //for solicitada com .enderecos
        public virtual ICollection<Endereco> Enderecos { get; set; }
    }
}
