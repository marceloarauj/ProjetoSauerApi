using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoEngSoftware.Models;

namespace ProjetoEngSoftware.Entity
{
    public class PedidoExameEntity : IEntityTypeConfiguration<PedidoExame>
    {
        public void Configure(EntityTypeBuilder<PedidoExame> builder)
        {
            builder.ToTable("tb_pedido_exame");
            builder.HasKey(x => x.IdPedidoExame);
            builder.Property(x => x.IdPedidoExame).ValueGeneratedOnAdd();
            builder.Property(x => x.DataExame).HasColumnName("dt_exame");
            builder.Property(x => x.HipoteseDiagnostica).HasColumnName("ds_hipotese_diagnostica");
            builder.Property(x => x.Recomendacoes).HasColumnName("ds_recomendacoes");
            builder.HasOne(x => x.Exame);
            builder.HasOne(x => x.Medico);
            builder.HasOne(x => x.Paciente);
        }
    }
}