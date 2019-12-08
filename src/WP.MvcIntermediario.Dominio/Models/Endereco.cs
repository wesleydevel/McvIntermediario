﻿using System;

namespace WP.MvcIntermediario.Dominio.Models
{
    public class Endereco : Entity
    {
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public Guid ClienteId { get; set; }

        public Cliente Cliente { get; set; }

        public override bool EhValido()
        {
            return true;
        }
    }
}
