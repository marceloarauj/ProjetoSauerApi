using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoEngSoftware.Models
{
    public class Login
    {
        public int Id {get;set;}
        public string UserLogin {get;set;}   
        public string Password {get;set;}
        public Medico Medico {get;set;}
    }
}