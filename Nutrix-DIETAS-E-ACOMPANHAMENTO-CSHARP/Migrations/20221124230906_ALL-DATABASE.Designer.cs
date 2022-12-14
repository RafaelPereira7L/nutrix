// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nutrix_DIETAS_E_ACOMPANHAMENTO_CSHARP.Models;

#nullable disable

namespace Nutrix_DIETAS_E_ACOMPANHAMENTO_CSHARP.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221124230906_ALL-DATABASE")]
    partial class ALLDATABASE
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Nutrix_DIETAS_E_ACOMPANHAMENTO_CSHARP.Models.Alimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Calcio")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("VARCHAR(40)");

                    b.Property<string>("Carboidrato")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("VARCHAR(40)");

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Cinzas")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("VARCHAR(40)");

                    b.Property<string>("Cobre")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("VARCHAR(40)");

                    b.Property<string>("Colesterol")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("VARCHAR(40)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR(255)");

                    b.Property<string>("EnergiaKcal")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("VARCHAR(40)");

                    b.Property<string>("EnergiaKj")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("VARCHAR(40)");

                    b.Property<string>("Ferro")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("VARCHAR(40)");

                    b.Property<string>("FibraAlimentar")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("VARCHAR(40)");

                    b.Property<string>("Fosforo")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("VARCHAR(40)");

                    b.Property<string>("Lipideos")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("VARCHAR(40)");

                    b.Property<string>("Magnesio")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("VARCHAR(40)");

                    b.Property<string>("Manganes")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("VARCHAR(40)");

                    b.Property<string>("Niacina")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("VARCHAR(40)");

                    b.Property<string>("Piridoxina")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("VARCHAR(40)");

                    b.Property<string>("Potassio")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("VARCHAR(40)");

                    b.Property<string>("Proteina")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("VARCHAR(40)");

                    b.Property<int>("Qtde")
                        .HasColumnType("int");

                    b.Property<string>("Rae")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("VARCHAR(40)");

                    b.Property<string>("Re")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("VARCHAR(40)");

                    b.Property<string>("Retinol")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("VARCHAR(40)");

                    b.Property<string>("Riboflavina")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("VARCHAR(40)");

                    b.Property<string>("Sodio")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("VARCHAR(40)");

                    b.Property<string>("Tiamina")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("VARCHAR(40)");

                    b.Property<string>("Umidade")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("VARCHAR(40)");

                    b.Property<string>("VitaminaC")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("VARCHAR(40)");

                    b.Property<string>("Zinco")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("VARCHAR(40)");

                    b.HasKey("Id");

                    b.ToTable("Alimentos");
                });

            modelBuilder.Entity("Nutrix_DIETAS_E_ACOMPANHAMENTO_CSHARP.Models.DadoPessoal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Altura")
                        .HasColumnType("int");

                    b.Property<string>("DataFicha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Peso")
                        .HasColumnType("int");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("DadosPessoais");
                });

            modelBuilder.Entity("Nutrix_DIETAS_E_ACOMPANHAMENTO_CSHARP.Models.Dieta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DataDieta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumeroRefeicoes")
                        .HasColumnType("int");

                    b.Property<int>("Objetivo")
                        .HasColumnType("int");

                    b.Property<string>("TituloDieta")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("VARCHAR(20)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Dietas");
                });

            modelBuilder.Entity("Nutrix_DIETAS_E_ACOMPANHAMENTO_CSHARP.Models.Refeicao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DietaId")
                        .HasColumnType("int");

                    b.Property<int>("NumeroRefeicao")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DietaId");

                    b.ToTable("Refeicoes");
                });

            modelBuilder.Entity("Nutrix_DIETAS_E_ACOMPANHAMENTO_CSHARP.Models.RefeicaoAlimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AlimentoId")
                        .HasColumnType("int");

                    b.Property<int>("RefeicaoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AlimentoId");

                    b.HasIndex("RefeicaoId");

                    b.ToTable("RefeicoesAlimentos");
                });

            modelBuilder.Entity("Nutrix_DIETAS_E_ACOMPANHAMENTO_CSHARP.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ConfirmacaoSenha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataNasc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAlergicoFrutosMar")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAlergicoGluten")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDiabetico")
                        .HasColumnType("bit");

                    b.Property<bool>("IsIntoleranteLactose")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SexoBiologico")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Nutrix_DIETAS_E_ACOMPANHAMENTO_CSHARP.Models.DadoPessoal", b =>
                {
                    b.HasOne("Nutrix_DIETAS_E_ACOMPANHAMENTO_CSHARP.Models.Usuario", "Usuario")
                        .WithMany("DadosPessoais")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Nutrix_DIETAS_E_ACOMPANHAMENTO_CSHARP.Models.Dieta", b =>
                {
                    b.HasOne("Nutrix_DIETAS_E_ACOMPANHAMENTO_CSHARP.Models.Usuario", "Usuario")
                        .WithMany("Dietas")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Nutrix_DIETAS_E_ACOMPANHAMENTO_CSHARP.Models.Refeicao", b =>
                {
                    b.HasOne("Nutrix_DIETAS_E_ACOMPANHAMENTO_CSHARP.Models.Dieta", "Dieta")
                        .WithMany("Refeicoes")
                        .HasForeignKey("DietaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dieta");
                });

            modelBuilder.Entity("Nutrix_DIETAS_E_ACOMPANHAMENTO_CSHARP.Models.RefeicaoAlimento", b =>
                {
                    b.HasOne("Nutrix_DIETAS_E_ACOMPANHAMENTO_CSHARP.Models.Alimento", "Alimento")
                        .WithMany("RefeicoesAlimentos")
                        .HasForeignKey("AlimentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nutrix_DIETAS_E_ACOMPANHAMENTO_CSHARP.Models.Refeicao", "Refeicao")
                        .WithMany("RefeicoesAlimentos")
                        .HasForeignKey("RefeicaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Alimento");

                    b.Navigation("Refeicao");
                });

            modelBuilder.Entity("Nutrix_DIETAS_E_ACOMPANHAMENTO_CSHARP.Models.Alimento", b =>
                {
                    b.Navigation("RefeicoesAlimentos");
                });

            modelBuilder.Entity("Nutrix_DIETAS_E_ACOMPANHAMENTO_CSHARP.Models.Dieta", b =>
                {
                    b.Navigation("Refeicoes");
                });

            modelBuilder.Entity("Nutrix_DIETAS_E_ACOMPANHAMENTO_CSHARP.Models.Refeicao", b =>
                {
                    b.Navigation("RefeicoesAlimentos");
                });

            modelBuilder.Entity("Nutrix_DIETAS_E_ACOMPANHAMENTO_CSHARP.Models.Usuario", b =>
                {
                    b.Navigation("DadosPessoais");

                    b.Navigation("Dietas");
                });
#pragma warning restore 612, 618
        }
    }
}
