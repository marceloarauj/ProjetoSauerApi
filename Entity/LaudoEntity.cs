using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoEngSoftware.Models;

namespace ProjetoEngSoftware.Entity
{
    public class LaudoEntity : IEntityTypeConfiguration<Laudo>
    {
        public void Configure(EntityTypeBuilder<Laudo> builder)
        {
            builder.ToTable("tb_laudo");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id_laudo");
            builder.Property(x => x.Status).HasColumnName("status");
            builder.HasOne(x => x.MedicoLaudo);
            builder.HasOne(x => x.Exame);
        }
    }
}