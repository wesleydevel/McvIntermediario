using System.Data.Entity.ModelConfiguration;
using WP.MvcIntermediario.Dominio.Models;

namespace WP.MvcIntermediario.Infra.Data.EntityConfig
{
    class EnderecoConfig : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfig()
        {
            HasKey(e => e.Id);
            Property(e => e.Logradouro)
                .IsRequired()
                .HasMaxLength(150);
            Property(e => e.Numero)
                .IsRequired()
                .HasMaxLength(20);
            Property(e => e.Bairro)
                .IsRequired()
                .HasMaxLength(50);
            Property(e => e.CEP)
                .IsRequired()
                .HasMaxLength(8)
                .IsFixedLength();
            Property(e => e.Complemento)
                .HasMaxLength(100);
            HasRequired(e => e.Cliente)
                .WithMany(c => c.Enderecos)
                .HasForeignKey(e => e.ClienteId);

            ToTable("Enderecos");



        }
    }
}
