using System;

namespace ProjetoEngSoftware.Models
{
    public class PedidoExame
    {
        public int IdPedidoExame {get;set;}
        public Paciente Paciente {get;set;}
        public Medico Medico {get;set;}
        public Exame Exame {get;set;}
        public DateTime DataExame {get;set;}
        public string HipoteseDiagnostica {get;set;}
        public string Recomendacoes {get;set;}
    }
}