

using DDDProject.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace DDDProject.Infra.Data.EntityConfig
{
    class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            HasKey(c => c.ClienteId);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(50);

            Property(c => c.Sobrenome)
               .IsRequired()
               .HasMaxLength(50);

            Property(c => c.Email)
               .IsRequired()
               .HasMaxLength(50);

        }
    }
}
