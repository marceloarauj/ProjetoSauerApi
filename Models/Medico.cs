namespace ProjetoEngSoftware.Models
{
    public class Medico
    {
        public int IdMedico {get;set;}
        public string Nome {get;set;}
        public string Crm {get;set;}
        public string Email {get;set;}
        public MedicoResidente Residente {get;set;}
        public MedicoProfessor Professor {get;set;}
        public Login Login {get;set;}
    }
}