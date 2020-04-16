using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoEngSoftware.Models
{
    [Table("login")]
    public class Cadastro
    {
        [Key]
        [Column("login")]
        public string login {get;set;}
        
        [Column("password")]
        public string password {get;set;}
    }
}