using System.ComponentModel.DataAnnotations;
using API.Models;
using System.Linq;

namespace API.Validations
{
    public class CpfEmUso : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string cpf = (string) value; /// converter o object value

            DataContext context = (DataContext)validationContext.GetService(typeof(DataContext));

            Morador morador = context.moradores.FirstOrDefault(y => y.Cpf.Equals(cpf));
            
            if (morador == null)
            {
                // Caso de Sucesso
                return ValidationResult.Success;
            }
            
            //Caso de Erro
            return new ValidationResult("O CPF do morador já está em uso!");
        }
    }
}