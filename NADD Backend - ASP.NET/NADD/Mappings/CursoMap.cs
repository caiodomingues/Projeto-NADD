using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NADD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NADD.Mapeamento
{
    public class CursoMap : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {
            builder.HasKey(d => d.CursoId);
            builder.Property(d => d.NomeCurso).IsRequired();
            builder.HasIndex(d => d.NomeCurso).IsUnique();

            builder.HasOne(tc => tc.Area).WithMany(tc => tc.Curso).HasForeignKey(f => f.AreaId);
            builder.HasMany(tc => tc.Disciplina).WithOne(tc => tc.Curso).OnDelete(DeleteBehavior.Cascade);

            builder.ToTable("Curso");
        }

        
    }
}
