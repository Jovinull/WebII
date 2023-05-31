﻿// <auto-generated />
using LagusImoveisWebII.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace LagusImoveisWebII.Migrations
{
    [DbContext(typeof(LagusImoveisWebIIContext))]
    partial class LagusImoveisWebIIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("LagusImoveisWebII.Models.Entites.EnderecoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasColumnName("bairro");

                    b.Property<int>("Cep")
                        .HasColumnType("integer")
                        .HasColumnName("cep");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasColumnName("cidade");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasColumnName("estado");

                    b.Property<int>("Numero")
                        .HasColumnType("integer")
                        .HasColumnName("numero");

                    b.Property<int>("PropriedadeId")
                        .HasColumnType("integer")
                        .HasColumnName("id_propriedade");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasColumnName("rua");

                    b.HasKey("Id");

                    b.HasIndex("PropriedadeId")
                        .IsUnique();

                    b.ToTable("endereco", (string)null);
                });

            modelBuilder.Entity("LagusImoveisWebII.Models.Entites.ImagemModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<byte[]>("Imagem")
                        .IsRequired()
                        .HasColumnType("bytea")
                        .HasColumnName("imagem");

                    b.Property<int>("PropriedadeId")
                        .HasColumnType("integer")
                        .HasColumnName("id_Propriedade");

                    b.HasKey("Id");

                    b.HasIndex("PropriedadeId");

                    b.ToTable("imagem", (string)null);
                });

            modelBuilder.Entity("LagusImoveisWebII.Models.Entites.PropriedadeModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(300)")
                        .HasColumnName("descricao");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("integer")
                        .HasColumnName("id_usuario");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("propriedade", (string)null);
                });

            modelBuilder.Entity("LagusImoveisWebII.Models.Entites.Propriedade_tipo_situacaoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("PropriedadeId")
                        .HasColumnType("integer")
                        .HasColumnName("id_propriedade");

                    b.Property<int>("Tipo_situacaoId")
                        .HasColumnType("integer")
                        .HasColumnName("id_Tipo_situacao");

                    b.Property<decimal>("Valor")
                        .HasPrecision(7, 2)
                        .HasColumnType("numeric(7,2)")
                        .HasColumnName("valor");

                    b.HasKey("Id");

                    b.HasIndex("PropriedadeId");

                    b.HasIndex("Tipo_situacaoId");

                    b.ToTable("propriedade_tipo_situacao", (string)null);
                });

            modelBuilder.Entity("LagusImoveisWebII.Models.Entites.Tipo_imovelModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasColumnName("descricao");

                    b.Property<int>("PropriedadeId")
                        .HasColumnType("integer")
                        .HasColumnName("id_propriedade");

                    b.HasKey("Id");

                    b.HasIndex("PropriedadeId")
                        .IsUnique();

                    b.ToTable("tipo_imovel", (string)null);
                });

            modelBuilder.Entity("LagusImoveisWebII.Models.Entites.Tipo_situacaoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasColumnName("descricao");

                    b.HasKey("Id");

                    b.ToTable("tipo_situacao", (string)null);
                });

            modelBuilder.Entity("LagusImoveisWebII.Models.Entites.UsuarioModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(40)")
                        .HasColumnName("email");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasColumnName("nome");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("varchar(8)")
                        .HasColumnName("senha");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasColumnName("sobrenome");

                    b.Property<int>("Telefone")
                        .HasColumnType("integer")
                        .HasColumnName("telefone");

                    b.HasKey("Id");

                    b.ToTable("usuario", (string)null);
                });

            modelBuilder.Entity("LagusImoveisWebII.Models.Entites.EnderecoModel", b =>
                {
                    b.HasOne("LagusImoveisWebII.Models.Entites.PropriedadeModel", "PropriedadeModel")
                        .WithOne()
                        .HasForeignKey("LagusImoveisWebII.Models.Entites.EnderecoModel", "PropriedadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PropriedadeModel");
                });

            modelBuilder.Entity("LagusImoveisWebII.Models.Entites.ImagemModel", b =>
                {
                    b.HasOne("LagusImoveisWebII.Models.Entites.PropriedadeModel", "PropriedadeModel")
                        .WithMany("ImagemModel")
                        .HasForeignKey("PropriedadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PropriedadeModel");
                });

            modelBuilder.Entity("LagusImoveisWebII.Models.Entites.PropriedadeModel", b =>
                {
                    b.HasOne("LagusImoveisWebII.Models.Entites.UsuarioModel", "UsuarioModel")
                        .WithMany("PropriedadeModel")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UsuarioModel");
                });

            modelBuilder.Entity("LagusImoveisWebII.Models.Entites.Propriedade_tipo_situacaoModel", b =>
                {
                    b.HasOne("LagusImoveisWebII.Models.Entites.PropriedadeModel", "PropriedadeModel")
                        .WithMany("Propriedade_tipo_situacaoModel")
                        .HasForeignKey("PropriedadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LagusImoveisWebII.Models.Entites.Tipo_situacaoModel", "Tipo_situacaoModel")
                        .WithMany("Propriedade_tipo_situacaoModel")
                        .HasForeignKey("Tipo_situacaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PropriedadeModel");

                    b.Navigation("Tipo_situacaoModel");
                });

            modelBuilder.Entity("LagusImoveisWebII.Models.Entites.Tipo_imovelModel", b =>
                {
                    b.HasOne("LagusImoveisWebII.Models.Entites.PropriedadeModel", "PropriedadeModel")
                        .WithOne()
                        .HasForeignKey("LagusImoveisWebII.Models.Entites.Tipo_imovelModel", "PropriedadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PropriedadeModel");
                });

            modelBuilder.Entity("LagusImoveisWebII.Models.Entites.PropriedadeModel", b =>
                {
                    b.Navigation("ImagemModel");

                    b.Navigation("Propriedade_tipo_situacaoModel");
                });

            modelBuilder.Entity("LagusImoveisWebII.Models.Entites.Tipo_situacaoModel", b =>
                {
                    b.Navigation("Propriedade_tipo_situacaoModel");
                });

            modelBuilder.Entity("LagusImoveisWebII.Models.Entites.UsuarioModel", b =>
                {
                    b.Navigation("PropriedadeModel");
                });
#pragma warning restore 612, 618
        }
    }
}
