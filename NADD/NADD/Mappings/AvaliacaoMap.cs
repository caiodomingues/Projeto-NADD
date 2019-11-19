using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NADD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NADD.Mapeamento
{
    public class AvaliacaoMap : IEntityTypeConfiguration<Avaliacao>
    {
        public void Configure(EntityTypeBuilder<Avaliacao> builder)
        {
            builder.HasKey(d => d.AvaliacaoId);

            builder.HasOne(tc => tc.Disciplinas).WithMany(tc => tc.Avaliacao).HasForeignKey(f => f.DisciplinaId);
            builder.HasMany(tc => tc.Questoes).WithOne(tc => tc.Avaliacao);
            builder.HasOne(tc => tc.Professor).WithMany(tc => tc.Avaliacao);

            builder.ToTable("Avaliacao");
        }
    }
}
