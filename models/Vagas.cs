using System.Reflection;
using System;
using System.ComponentModel.DataAnnotations;
using API.Models;
using System.Collections.Generic;

namespace API.Models
{
    public class Vagas
    {
        public Vagas () => CriadoEm = DateTime.Now;
        public int       VagasId { get; set; }
        public  Morador Morador { get; set; }
        public DateTime  CriadoEm { get; set; }
    }
}