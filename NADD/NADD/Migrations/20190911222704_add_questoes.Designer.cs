﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NADD.Models;

namespace NADD.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20190911222704_add_questoes")]
    partial class add_questoes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NADD.Models.Area", b =>
                {
                    b.Property<int>("AreaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DtCriacao");

                    b.Property<string>("NomeArea")
                        .IsRequired();

                    b.Property<bool>("Status");

                    b.HasKey("AreaId");

                    b.HasIndex("NomeArea")
                        .IsUnique();

                    b.ToTable("Area");
                });

            modelBuilder.Entity("NADD.Models.Avaliacao", b =>
                {
                    b.Property<int>("AvaliacaoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DisciplinaId");

                    b.Property<DateTime>("DtAplicacao");

                    b.Property<DateTime>("DtCriacao");

                    b.Property<bool>("Eqdistvquest");

                    b.Property<double>("Media");

                    b.Property<string>("Observacao");

                    b.Property<bool>("PQuestMultdisc");

                    b.Property<string>("Ppquestcontext");

                    b.Property<int>("ProfessorId");

                    b.Property<int>("QtyQuestoes");

                    b.Property<bool>("RefBibliograficas");

                    b.Property<double>("TotValor");

                    b.Property<bool>("ValorProvaExp");

                    b.Property<bool>("ValorQuestExp");

                    b.HasKey("AvaliacaoId");

                    b.HasIndex("DisciplinaId");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Avaliacao");
                });

            modelBuilder.Entity("NADD.Models.Curso", b =>
                {
                    b.Property<int>("CursoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AreaId");

                    b.Property<DateTime>("DtCriacao");

                    b.Property<string>("NomeCurso")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<bool>("Status");

                    b.HasKey("CursoId");

                    b.HasIndex("AreaId");

                    b.HasIndex("NomeCurso")
                        .IsUnique();

                    b.ToTable("Curso");
                });

            modelBuilder.Entity("NADD.Models.Disciplina", b =>
                {
                    b.Property<int>("DisciplinaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CursoId");

                    b.Property<DateTime>("DtCriacao");

                    b.Property<string>("NomeDisciplina")
                        .IsRequired();

                    b.Property<bool>("Status");

                    b.HasKey("DisciplinaId");

                    b.HasIndex("CursoId");

                    b.HasIndex("NomeDisciplina")
                        .IsUnique();

                    b.ToTable("Disciplina");
                });

            modelBuilder.Entity("NADD.Models.Professor", b =>
                {
                    b.Property<int>("ProfessorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CpfProfessor")
                        .IsRequired();

                    b.Property<string>("EmailProfessor")
                        .IsRequired();

                    b.Property<string>("NomeProfessor")
                        .IsRequired();

                    b.Property<string>("TelProfessor")
                        .IsRequired();

                    b.HasKey("ProfessorId");

                    b.ToTable("Professor");
                });

            modelBuilder.Entity("NADD.Models.Questoes", b =>
                {
                    b.Property<int>("QuestoesId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AvaliacaoId");

                    b.Property<string>("NumeroQuestao");

                    b.Property<string>("Observacao");

                    b.Property<string>("Tipo");

                    b.Property<double>("Valor");

                    b.HasKey("QuestoesId");

                    b.HasIndex("AvaliacaoId");

                    b.ToTable("Questoes");
                });

            modelBuilder.Entity("NADD.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmailUsuario");

                    b.Property<string>("NomeUsuario");

                    b.Property<string>("SenhaUsuario");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("NADD.Models.Avaliacao", b =>
                {
                    b.HasOne("NADD.Models.Disciplina", "Disciplinas")
                        .WithMany("Avaliacao")
                        .HasForeignKey("DisciplinaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NADD.Models.Professor", "Professor")
                        .WithMany("Avaliacao")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NADD.Models.Curso", b =>
                {
                    b.HasOne("NADD.Models.Area", "Area")
                        .WithMany("Curso")
                        .HasForeignKey("AreaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NADD.Models.Disciplina", b =>
                {
                    b.HasOne("NADD.Models.Curso", "Curso")
                        .WithMany("Disciplina")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NADD.Models.Questoes", b =>
                {
                    b.HasOne("NADD.Models.Avaliacao", "Avaliacao")
                        .WithMany("Questoes")
                        .HasForeignKey("AvaliacaoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
