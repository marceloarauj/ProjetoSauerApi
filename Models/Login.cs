using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoEngSoftware.Models
{
    [Table("login")]
    public class Login
    {
        [Column("id")]
        public int id {get;set;}
        [Column("login")]
        public string login {get;set;}
        
        [Column("password")]
        public string password {get;set;}
    }
}