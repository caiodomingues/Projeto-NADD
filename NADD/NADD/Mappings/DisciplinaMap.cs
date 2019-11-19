using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NADD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NADD.Mapeamento
{
    public class DisciplinaMap : IEntityTypeConfiguration<Disciplina>
    {
            public void Configure(EntityTypeBuilder<Disciplina> builder)
            {
                builder.HasKey(d => d.DisciplinaId);
                builder.Property(d => d.NomeDisciplina).IsRequired();
                builder.HasIndex(d => d.NomeDisciplina).IsUnique();

                builder.HasOne(tc => tc.Curso).WithMany(tc => tc.Disciplina).HasForeignKey(f => f.CursoId);
                builder.HasMany(s => s.Avaliacao).WithOne(x => x.Disciplinas);

                builder.ToTable("Disciplina");
            }
        }
}
