using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoEngSoftware.Models;

namespace ProjetoEngSoftware.Entity
{
    public class PacienteEntity : IEntityTypeConfiguration<Paciente>
    {
        public void Configure(EntityTypeBuilder<Paciente> builder)
        {
            builder.ToTable("tb_paciente");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id_paciente").ValueGeneratedOnAdd();
            builder.Property(x => x.DataNascimento).HasColumnName("dt_nascimento");
            builder.Property(x => x.Sexo).HasColumnName("tp_sexo");
            builder.HasOne(x => x.Etnia);
            builder.Property(x => x.Nome).HasColumnName("nm_paciente");
        }
    }
}