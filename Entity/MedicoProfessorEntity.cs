using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoEngSoftware.Models;

namespace ProjetoEngSoftware.Entity
{
    public class MedicoProfessorEntity : IEntityTypeConfiguration<MedicoProfessor>
    {
        public void Configure(EntityTypeBuilder<MedicoProfessor> builder)
        {
            builder.ToTable("tb_docente");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id_docente");
            builder.Property(x => x.DescricaoTitulacao).HasColumnName("ds_titulacao");
        }
    }
}