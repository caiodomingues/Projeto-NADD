using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NADD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NADD.Mapeamento
{
    public class ProfessorMap : IEntityTypeConfiguration<Professor>
    {
            public void Configure(EntityTypeBuilder<Professor> builder)
            {
                builder.HasKey(d => d.ProfessorId);

            builder.HasMany(tc => tc.Avaliacao).WithOne(tc => tc.Professor);

            builder.ToTable("Professor");

            }
        }
}
