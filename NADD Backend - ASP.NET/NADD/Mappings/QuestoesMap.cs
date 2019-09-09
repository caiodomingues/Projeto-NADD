using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NADD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NADD.Mapeamento
{
    public class QuestoesMap : IEntityTypeConfiguration<Questoes>
    {

        public void Configure(EntityTypeBuilder<Questoes> builder)
        {
            builder.HasKey(d => d.QuestoesId);
            builder.Property(d => d.Valor).IsRequired();
            builder.Property(d => d.Tipo).IsRequired();
            builder.Property(d => d.Observacao).IsRequired();

            builder.HasOne(tc => tc.Avaliacao).WithMany(tc => tc.Questoes).HasForeignKey(f => f.AvaliacaoId);

            builder.ToTable("Questoes");
        }
    }
}
