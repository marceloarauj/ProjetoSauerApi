namespace ProjetoEngSoftware.Models
{
    public class Laudo
    {
        public int Id {get;set;}
        public Exame Exame {get;set;}
        public MedicoResidente MedicoLaudo {get;set;}
        public string DescricaoLaudo {get;set;}
        public bool Status {get;set;}
    }
}