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
            builder.Property(d => d.NomeAvaliador).IsRequired();
            builder.Property(d => d.Email).IsRequired();
            builder.Property(d => d.HoraInicio).IsRequired();
            builder.Property(d => d.HoraConclusao).IsRequired();
            builder.Property(d => d.ValorProvaExp).IsRequired();
            builder.Property(d => d.RefBibliograficas);
            builder.Property(d => d.PQuestMultdisc);
            builder.Property(d => d.Eqdistvquest);
            builder.Property(d => d.Ppquestcontext);
            builder.Property(d => d.Observacao);
            builder.Property(d => d.QtyQuestoes);
            builder.Property(d => d.Media); ;
            builder.Property(d => d.TotValor);

            builder.HasOne(tc => tc.Disciplinas).WithMany(tc => tc.Avaliacao).HasForeignKey(f => f.DisciplinaId);
            builder.HasMany(tc => tc.Questoes).WithOne(tc => tc.Avaliacao);

            builder.ToTable("Avaliacao");
        }
    }
}
