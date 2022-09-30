using System;
using System.ComponentModel.DataAnnotations;
using API.Validations;

namespace API.Models
{
    public class Morador
    {
        public Morador () => CriadoEm = DateTime.Now;
        public int      MoradorId { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório!")] 
        public string   Nome { get; set; }

        [Required(ErrorMessage = "O campo CPF é obrigatório!")]
        [StringLength(
            11,
            MinimumLength = 11,
            ErrorMessage = "O campo CPF deve conter 11 caracteres!"
        )]
        [CpfEmUso]
        public string   Cpf { get; set; }

        [Required(ErrorMessage = "O campo apartamento é obrigatório!")]         
        public string   Apartamento { get; set; }

        [EmailAddress(ErrorMessage = "E-mail Inválido!")]       
        public string   Email { get; set;}

        [Required(ErrorMessage = "O campo bloco é obrigatório!")]        
        public string   Bloco { get; set; }

        [Required(ErrorMessage = "O campo Modelo do Veículo é obrigatório!")] 
        public string   Modelo_veiculo { get; set; }

        [Required(ErrorMessage = "O campo cor é obrigatório!")] 
        public string   Cor { get; set;}

        [Required(ErrorMessage = "O campo placa é obrigatório!")] 
        public string   Placa { get; set; }

        public DateTime CriadoEm { get; set; }
    }
}