using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoEngSoftware.Models;

namespace ProjetoEngSoftware.Entity
{
    public class LoginEntity : IEntityTypeConfiguration<Login>
    {
        public void Configure(EntityTypeBuilder<Login> builder)
        {
            builder.ToTable("tb_login");
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Medico).WithOne(y => y.Login).HasForeignKey<Login>(e => e.Id);
            builder.Property(x => x.UserLogin).HasColumnName("login");
            builder.Property(x => x.Password).HasColumnName("password");
        }
    }
}