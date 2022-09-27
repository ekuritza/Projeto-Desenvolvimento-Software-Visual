using System;
using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Morador
    {
        public Morador () => CriadoEm = DateTime.Now;
        public int      MoradorId { get; set; }
        public string   Nome { get; set; }
        public string   Cpf { get; set; }
        public string   Apartamento { get; set; }
        public string   Email { get; set;}
        public string   Bloco { get; set; }
        public string   Modelo_veiculo { get; set; }
        public string   Cor { get; set;}
        public string   Placa { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}