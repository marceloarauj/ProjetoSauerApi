using System;
using System.Linq;
using ProjetoEngSoftware.Contexts;
using ProjetoEngSoftware.DTO;
using ProjetoEngSoftware.Models;

namespace ProjetoEngSoftware.Repositories
{
    public class CadastroRepository
    {
        public CadastroRepository(Context cadastroContext){
            this.cadastroContext = cadastroContext;
        }
        private Context cadastroContext;

        public PerfilDTO efetuarCadastroMedico(DadosCadastroDTO dados){
            Login cadastro = this.cadastroContext.Logins
                                    .Where(user => user.UserLogin == dados.Login).FirstOrDefault();
            
            if(cadastro != null)
                return null;

            Medico medico = new Medico();
            medico.Nome = dados.Medico.Nome;
            medico.Crm = dados.Medico.Crm;

            Login novoUsuario = new Login();
            novoUsuario.UserLogin = dados.Login;
            novoUsuario.Password = dados.Password;

            medico.Login = novoUsuario;

            cadastroContext.Medicos.Add(medico);
            cadastroContext.SaveChanges();

            return new PerfilDTO{Login = novoUsuario.UserLogin, Nome =medico.Nome, UserRole = "Medico"};
        }
        public PerfilDTO efetuarCadastroProfessor(DadosCadastroDTO dados){
            Login cadastro = this.cadastroContext.Logins
                                    .Where(user => user.UserLogin == dados.Login).FirstOrDefault();
            
            if(cadastro != null)
                return null;

            Medico medico = new Medico();
            medico.Nome = dados.Medico.Nome;
            medico.Crm = dados.Medico.Crm;

            Login novoUsuario = new Login();
            novoUsuario.UserLogin = dados.Login;
            novoUsuario.Password = dados.Password;

            MedicoProfessor professor = new MedicoProfessor();

            medico.Login = novoUsuario;
            medico.Professor = professor;
            
            cadastroContext.Medicos.Add(medico);
            cadastroContext.SaveChanges();

            return new PerfilDTO{Login = novoUsuario.UserLogin, Nome =medico.Nome, UserRole = "Professor"};
        }
        public PerfilDTO efetuarCadastroResidente(DadosCadastroDTO dados){
            Login cadastro = this.cadastroContext.Logins
                                .Where(user => user.UserLogin == dados.Login).FirstOrDefault();
            
            if(cadastro != null)
                return null;

            Medico medico = new Medico();
            medico.Nome = dados.Medico.Nome;
            medico.Crm = dados.Medico.Crm;

            Login novoUsuario = new Login();
            novoUsuario.UserLogin = dados.Login;
            novoUsuario.Password = dados.Password;

            MedicoResidente residente = new MedicoResidente();
            residente.DataResidencia = DateTime.Today;

            medico.Login = novoUsuario;
            medico.Residente = residente;
            
            cadastroContext.Medicos.Add(medico);
            cadastroContext.SaveChanges();

            return new PerfilDTO{Login = novoUsuario.UserLogin, Nome =medico.Nome, UserRole = "Residente"};
        }
    }
}