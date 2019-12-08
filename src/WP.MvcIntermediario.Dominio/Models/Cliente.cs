using System;
using System.Collections.Generic;

namespace WP.MvcIntermediario.Dominio.Models
{
    public class Cliente : Entity
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; private set; }
        public bool Excluido { get; private set; }
        public virtual ICollection<Endereco> Enderecos { get; private set; }
        public Cliente()
        {
            Enderecos = new List<Endereco>();
        }

        public override bool EhValido()
        {
            return true;
        }
        public void Ativar()
        {
            Ativo = true;
            Excluido = false;
        }

        //ADDHOC SETTER
        public void AdicionarEndereco(Endereco endereco)
        {
            if (!endereco.EhValido())
                return;
            Enderecos.Add(endereco);
        } 
        public void Excluir()
        {
            Ativo = false;
            Excluido = true;
        }
    }   
}
