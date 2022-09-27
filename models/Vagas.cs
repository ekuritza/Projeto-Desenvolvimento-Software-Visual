using System;
using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Vagas
    {
        public Vagas () => CriadoEm = DateTime.Now;
        public int       Id { get; set; }
        public int       Id_morador { get; set; }
        public Morador moradores { get; set; }
        public DateTime  CriadoEm { get; set; }
    }
}