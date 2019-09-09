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
                builder.Property(d => d.NomeProfessor).IsRequired();
                builder.HasIndex(d => d.NomeProfessor).IsUnique();
                builder.Property(d => d.EmailProfessor).IsRequired();
                builder.HasIndex(d => d.EmailProfessor).IsUnique();
                builder.Property(d => d.TelProfessor).IsRequired();
                builder.Property(d => d.CpfProfessor).IsRequired();
                builder.HasIndex(d => d.CpfProfessor).IsUnique();



            builder.ToTable("Professor");
            }
        }
}
