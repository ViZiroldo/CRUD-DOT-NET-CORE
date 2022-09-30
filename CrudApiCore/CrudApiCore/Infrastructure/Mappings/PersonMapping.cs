using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Mappings
{
    public class ProdutoMapping : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(p => p.LastName)
                .IsRequired()
                .HasColumnType("varchar(1000)");

            builder.Property(p => p.CPF)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(p => p.Nationality)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(p => p.CEP)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(p => p.State)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(p => p.City)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(p => p.PublicPlace)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(p => p.Email)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(p => p.Phone)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.ToTable("Persons");
        }
    }
}
