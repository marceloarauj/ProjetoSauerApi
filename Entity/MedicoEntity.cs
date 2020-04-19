using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoEngSoftware.Models;

namespace ProjetoEngSoftware.Entity
{
    public class MedicoEntity : IEntityTypeConfiguration<Medico>
    {
        public void Configure(EntityTypeBuilder<Medico> builder)
        {
            builder.ToTable("tb_medico");
            builder.HasKey(x => x.IdMedico);
            builder.Property(x => x.IdMedico).HasColumnName("id_medico").ValueGeneratedOnAdd();
            builder.Property(x => x.Nome).HasColumnName("nm_medico");
            builder.Property(x=> x.Crm).HasColumnName("crm");
            builder.Property(x => x.Email).HasColumnName("email");
        }
    }
}