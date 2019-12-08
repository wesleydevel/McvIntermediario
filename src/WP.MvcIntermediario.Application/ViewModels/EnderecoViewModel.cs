using System;
using System.ComponentModel.DataAnnotations;

namespace WP.MvcIntermediario.Application.ViewModels
{
    public class EnderecoViewModel
    {
        public EnderecoViewModel()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage ="Preencha o campo logradouro")]
        [MaxLength(100, ErrorMessage ="Máximo de {0} caracteres")]
        [MinLength(2, ErrorMessage ="Minimo de {0} caracteres")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Preencha o campo Numero")]
        [MaxLength(100, ErrorMessage = "Máximo de {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo de {0} caracteres")]
        public string Numero { get; set; }

        [MaxLength(150, ErrorMessage = "Máximo de {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo de {0} caracteres")]
        public string Complemento { get; set; }


        [Required(ErrorMessage = "Preencha o campo Bairro")]
        [MaxLength(100, ErrorMessage = "Máximo de {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo de {0} caracteres")]
        public string Bairro { get; set; }


        [Required(ErrorMessage = "Preencha o campo CEP")]
        [MaxLength(8, ErrorMessage = "Máximo de {0} caracteres")]
        [MinLength(8, ErrorMessage = "Minimo de {0} caracteres")]
        public string CEP { get; set; }

        [Required(ErrorMessage = "Preencha o campo Cidade")]
        [MaxLength(100, ErrorMessage = "Máximo de {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo de {0} caracteres")]
        public string Cidade { get; set; }


        [Required(ErrorMessage = "Preencha o campo Estado")]
        [MaxLength(100, ErrorMessage = "Máximo de {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo de {0} caracteres")]
        public string Estado { get; set; }
        
        [ScaffoldColumn(false)]
        public Guid ClienteId { get; set; }
    }
}
