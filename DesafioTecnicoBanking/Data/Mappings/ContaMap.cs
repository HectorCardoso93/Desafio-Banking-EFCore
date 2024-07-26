using DesafioTecnicoBanking.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTecnicoBanking.Data.Mappings
{
    public class ContaMap : IEntityTypeConfiguration<Conta>
    {
        public void Configure(EntityTypeBuilder<Conta> builder)
        {
            builder.ToTable("Conta");

            builder.HasKey(x => x.NumeroConta);

            builder.Property(x => x.Agencia)
                .IsRequired()
                .HasColumnName("Agencia")
                .HasColumnType("INT")
                .HasDefaultValue(100);

            builder.HasOne(x => x.Titular)
                .WithMany()
                .HasForeignKey(x => x.CPFTitular);

            builder.Property(x => x.Saldo)
                .IsRequired()
                .HasColumnName("Saldo")
                .HasColumnType("FLOAT");

            builder.Property(x => x.ChequeEspecial)
                .IsRequired()
                .HasColumnName("ChequeEspecial")
                .HasColumnType("FLOAT")
                .HasDefaultValue(300);

            builder.Property(x => x.IsContaCorrente)
                .IsRequired()
                .HasColumnName("IsContaCorrente")
                .HasColumnType("BIT")
                .HasDefaultValue(false);

            builder.Property(x => x.DataUltimaOperacao)
                .IsRequired()
                .HasColumnName("DataUltimaOperacao")
                .HasColumnType("DATETIME")
                .HasDefaultValue("2000-01-01 00:00:00");
        }
    }
}
