using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ProjetoEngSoftware.Configurations;
using ProjetoEngSoftware.Contexts;
using ProjetoEngSoftware.DTO;
using ProjetoEngSoftware.Models;

namespace ProjetoEngSoftware.Repositories
{
    public class LoginRepository
    {
        public LoginRepository(Context loginContext){
            this.loginContext = loginContext;
        }
        private Context loginContext;
        public PerfilDTO efetuarLogin(LoginDTO login){
                        
            Login loginUser = this.loginContext.Logins.Where(user => user.UserLogin == login.Login &&
                                                        user.Password == login.Password).FirstOrDefault();
            
            if(loginUser == null)
                return null;

            Medico medico = this.loginContext.Medicos.Where
                                    (medico => medico.Login.Id == loginUser.Id).FirstOrDefault();

            MedicoResidente residente = this.loginContext.Residentes.Where
                                            (residente => residente.Id == loginUser.Id).FirstOrDefault();

            MedicoProfessor professor = this.loginContext.Professores.Where
                                            (professor => professor.Id == loginUser.Id).FirstOrDefault();
            

            if(residente != null)
                return new PerfilDTO{Login = loginUser.UserLogin,
                                     UserRole = "Residente",
                                     Nome = medico.Nome};

            if(professor != null)
                return new PerfilDTO{Login = loginUser.UserLogin,
                                     UserRole = "Professor",
                                     Nome = medico.Nome};

            return new PerfilDTO{Login = loginUser.UserLogin,
                                 UserRole = "Medico",
                                 Nome = medico.Nome};             
        }
    }
}