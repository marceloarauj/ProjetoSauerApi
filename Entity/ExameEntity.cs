using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoEngSoftware.Models;

namespace ProjetoEngSoftware.Entity
{
    public class ExameEntity : IEntityTypeConfiguration<Exame>
    {
        public void Configure(EntityTypeBuilder<Exame> builder)
        {
            builder.ToTable("tb_exame");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id_exame");
            builder.Property(x => x.NomeExame).HasColumnName("nm_exame");
        }
    }
}