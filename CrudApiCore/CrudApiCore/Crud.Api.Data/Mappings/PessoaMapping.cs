using Crud.Api.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Crud.Api.Data.Mappings
{
    public class ProdutoMapping : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(p => p.Sobrenome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(p => p.CPF)
                .IsRequired()
                .HasColumnType("varchar(11)");

            builder.Property(p => p.Nacionalidade)
               .IsRequired()
               .HasColumnType("varchar(30)");

            builder.Property(p => p.CEP)
               .IsRequired()
               .HasColumnType("varchar(8)");

            builder.Property(p => p.Estado)
               .IsRequired()
               .HasColumnType("varchar(100)");

            builder.Property(p => p.Cidade)
               .IsRequired()
               .HasColumnType("varchar(100)");

            builder.Property(p => p.Logradouro)
               .IsRequired()
               .HasColumnType("varchar(100)");

            builder.Property(p => p.Email)
               .IsRequired()
               .HasColumnType("varchar(100)");

            builder.Property(p => p.Telefone)
               .IsRequired()
               .HasColumnType("varchar(11)");

            builder.Property(p => p.Numero)
               .IsRequired()
               .HasColumnType("int");

            builder.ToTable("Pessoas");
        }
    }
}
