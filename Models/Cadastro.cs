using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoEngSoftware.Models
{
    
    public class Cadastro
    {
        public string login {get;set;}
        public string password {get;set;}

        public string email {get;set;}
    }
}