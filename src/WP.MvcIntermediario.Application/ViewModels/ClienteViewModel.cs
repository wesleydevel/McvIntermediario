
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WP.MvcIntermediario.Application.ViewModels
{
    public class ClienteViewModel
    {
        public ClienteViewModel()
        {
            Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo de 150 caracteres")]
        [MinLength(2, ErrorMessage = "Minimo de 2 caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Prrencha o campo E-mail")]
        [MaxLength(150, ErrorMessage = "Maximo de {0} caracteres")]
        [EmailAddress(ErrorMessage = "Preencha com um E-mail valido")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Preencha o campo CPF")]
        [MaxLength(11, ErrorMessage = "Máximo de {0} Caracteres")]
        [Display(Name = "CPF")]
        public string CPF { get; set; }
        [Display(Name = "Data de Nascimento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato invalido")]
        public DateTime DataNascimento { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        [ScaffoldColumn(false)]
        public bool Ativo { get; set; }
        [ScaffoldColumn(false)]
        public bool Excluido { get; set; }
        //[ScaffoldColumn(false)]
        //public DomainValidation.Validation.VAlidationResult ValidationResult { get; set; }
        public IEnumerable<EnderecoViewModel> Enderecos { get; set; }

    }
}
