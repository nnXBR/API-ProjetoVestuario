﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repositorio;

namespace Repositorio.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20211108224717_Versao4")]
    partial class Versao4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entidades.Imagens", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Produtoid")
                        .HasColumnType("int");

                    b.Property<string>("img_caminho")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Produtoid");

                    b.ToTable("imagens");
                });

            modelBuilder.Entity("Entidades.Produto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Usuarioid")
                        .HasColumnType("int");

                    b.Property<string>("prod_Descricao")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime>("prod_dataCadastro")
                        .HasPrecision(6)
                        .HasColumnType("datetime2(6)");

                    b.Property<decimal>("prod_preco")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("prod_statuspublicacao")
                        .HasColumnType("int");

                    b.Property<int>("prod_usuariocadastro")
                        .HasColumnType("int");

                    b.Property<int>("produtoCategoriaid")
                        .HasColumnType("int");

                    b.Property<int>("produtoGeneroid")
                        .HasColumnType("int");

                    b.Property<int>("produtoMarcaid")
                        .HasColumnType("int");

                    b.Property<int?>("produtoStatusid")
                        .HasColumnType("int");

                    b.Property<int>("produtoTamanhoid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Usuarioid");

                    b.HasIndex("produtoCategoriaid");

                    b.HasIndex("produtoGeneroid");

                    b.HasIndex("produtoMarcaid");

                    b.HasIndex("produtoStatusid");

                    b.HasIndex("produtoTamanhoid");

                    b.ToTable("produtos");
                });

            modelBuilder.Entity("Entidades.Usuario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("UsuarioTipoid")
                        .HasColumnType("int");

                    b.Property<string>("usu_cpf")
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<DateTime>("usu_dataCriacao")
                        .HasPrecision(6)
                        .HasColumnType("datetime2(6)");

                    b.Property<string>("usu_email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("usu_nome")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("usu_senha")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("usuarioEnderecoid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("UsuarioTipoid");

                    b.HasIndex("usuarioEnderecoid");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Entidades.produtoCategoria", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("cat_descricao")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("id");

                    b.ToTable("categorias");
                });

            modelBuilder.Entity("Entidades.produtoGenero", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("genero_desc")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("id");

                    b.ToTable("generos");
                });

            modelBuilder.Entity("Entidades.produtoMarca", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("marca_desc")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("id");

                    b.ToTable("marcas");
                });

            modelBuilder.Entity("Entidades.produtoStatus", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("status_desc")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("id");

                    b.ToTable("produtoStatus");
                });

            modelBuilder.Entity("Entidades.produtoTamanho", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("tamanho_desc")
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.HasKey("id");

                    b.ToTable("tamanhos");
                });

            modelBuilder.Entity("Entidades.usuarioEndereco", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Usuarioid")
                        .HasColumnType("int");

                    b.Property<string>("end_CEP")
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.Property<string>("end_bairro")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("end_cidade")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("end_complemento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("end_descricao")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("end_endereco")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("end_estado")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("end_numero")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("end_referencia")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("id");

                    b.ToTable("usuarioEndereco");
                });

            modelBuilder.Entity("Entidades.usuarioTipo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("usuarioTipo_desc")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("id");

                    b.ToTable("usuarioTipo");
                });

            modelBuilder.Entity("Entidades.Imagens", b =>
                {
                    b.HasOne("Entidades.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("Produtoid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("Entidades.Produto", b =>
                {
                    b.HasOne("Entidades.Usuario", null)
                        .WithMany("usuarioEnderecos")
                        .HasForeignKey("Usuarioid");

                    b.HasOne("Entidades.produtoCategoria", "produtoCategoria")
                        .WithMany("produtos")
                        .HasForeignKey("produtoCategoriaid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entidades.produtoGenero", "produtoGenero")
                        .WithMany("produtos")
                        .HasForeignKey("produtoGeneroid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entidades.produtoMarca", "produtoMarca")
                        .WithMany("produtos")
                        .HasForeignKey("produtoMarcaid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entidades.produtoStatus", null)
                        .WithMany("Produto")
                        .HasForeignKey("produtoStatusid");

                    b.HasOne("Entidades.produtoTamanho", "produtoTamanho")
                        .WithMany("produtos")
                        .HasForeignKey("produtoTamanhoid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("produtoCategoria");

                    b.Navigation("produtoGenero");

                    b.Navigation("produtoMarca");

                    b.Navigation("produtoTamanho");
                });

            modelBuilder.Entity("Entidades.Usuario", b =>
                {
                    b.HasOne("Entidades.usuarioTipo", "UsuarioTipo")
                        .WithMany("Usuarios")
                        .HasForeignKey("UsuarioTipoid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entidades.usuarioEndereco", null)
                        .WithMany("Usuario")
                        .HasForeignKey("usuarioEnderecoid");

                    b.Navigation("UsuarioTipo");
                });

            modelBuilder.Entity("Entidades.Usuario", b =>
                {
                    b.Navigation("usuarioEnderecos");
                });

            modelBuilder.Entity("Entidades.produtoCategoria", b =>
                {
                    b.Navigation("produtos");
                });

            modelBuilder.Entity("Entidades.produtoGenero", b =>
                {
                    b.Navigation("produtos");
                });

            modelBuilder.Entity("Entidades.produtoMarca", b =>
                {
                    b.Navigation("produtos");
                });

            modelBuilder.Entity("Entidades.produtoStatus", b =>
                {
                    b.Navigation("Produto");
                });

            modelBuilder.Entity("Entidades.produtoTamanho", b =>
                {
                    b.Navigation("produtos");
                });

            modelBuilder.Entity("Entidades.usuarioEndereco", b =>
                {
                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Entidades.usuarioTipo", b =>
                {
                    b.Navigation("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
