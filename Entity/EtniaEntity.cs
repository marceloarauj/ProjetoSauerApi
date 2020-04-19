using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoEngSoftware.Models;

namespace ProjetoEngSoftware.Entity
{
    public class EtniaEntity: IEntityTypeConfiguration<Etnia>
    {
        public void Configure(EntityTypeBuilder<Etnia> builder)
        {
            builder.ToTable("tb_etnia");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id_etnia");
            builder.Property(x => x.Descricao).HasColumnName("ds_etnia");

        }
    
        
    }
}