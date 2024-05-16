using Metalcoin.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MetalCoin.Infra.Data.Mappings
{
    internal class CupomMapping : IEntityTypeConfiguration<Cupom>
    {
        public void Configure(EntityTypeBuilder<Cupom> builder)
        {
            builder.ToTable("Cupom");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Codigo).IsRequired().HasColumnType("varchar(100)");
            builder.Property(p => p.Descricao).HasColumnType("varchar(255)");
            builder.Property(p => p.ValorDesconto).IsRequired().HasColumnType("decimal(10,2)");
            builder.Property(p => p.TipoDesconto).IsRequired();
            builder.Property(p => p.DataValidade).IsRequired();
            builder.Property(p => p.QuantidadeLiberada).IsRequired();
            builder.Property(p => p.QuantidadeUsada).IsRequired();
            builder.Property(p => p.Status).IsRequired();
        }
    }
}
