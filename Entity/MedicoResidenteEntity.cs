using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoEngSoftware.Models;

namespace ProjetoEngSoftware.Entity
{
    public class MedicoResidenteEntity : IEntityTypeConfiguration<MedicoResidente>
    {
        public void Configure(EntityTypeBuilder<MedicoResidente> builder)
        {
            builder.ToTable("tb_residente");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id_residente");
            builder.HasOne(x=> x.Medico).WithOne(y => y.Residente).HasForeignKey<MedicoResidente>( z=>z.Id);
            builder.Property(x => x.DataResidencia).HasColumnName("dt_residencia");
        }
    }
}