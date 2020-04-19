using System;

namespace ProjetoEngSoftware.Models
{
    public class MedicoResidente
    {
        public int Id {get;set;}
        public DateTime DataResidencia{get;set;}
        public Medico Medico {get;set;}
    }
}