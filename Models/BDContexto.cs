using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Cadastro_Veiculos.Models
{
    public partial class BDContexto : DbContext
    {
        public BDContexto()
        {
        }

        public BDContexto(DbContextOptions<BDContexto> options)
            : base(options)
        {
        }

        public virtual DbSet<Estado> Estado { get; set; }
        public virtual DbSet<Marca> Marca { get; set; }
        public virtual DbSet<Modelo> Modelo { get; set; }
        public virtual DbSet<ModeloOpcional> ModeloOpcional { get; set; }
        public virtual DbSet<Opcional> Opcional { get; set; }
        public virtual DbSet<Proprietario> Proprietario { get; set; }
        public virtual DbSet<Veiculo> Veiculo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;password=Ab!91576207;database=projeto");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estado>(entity =>
            {
                entity.HasKey(e => e.CodEstado)
                    .HasName("PRIMARY");

                entity.ToTable("estado");

                entity.Property(e => e.CodEstado).HasColumnName("codEstado");

                entity.Property(e => e.Tipo)
                    .HasColumnName("tipo")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Marca>(entity =>
            {
                entity.HasKey(e => e.CodMarca)
                    .HasName("PRIMARY");

                entity.ToTable("marca");

                entity.Property(e => e.CodMarca).HasColumnName("codMarca");

                entity.Property(e => e.Nome)
                    .HasColumnName("nome")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Modelo>(entity =>
            {
                entity.HasKey(e => e.CodModelo)
                    .HasName("PRIMARY");

                entity.ToTable("modelo");

                entity.HasIndex(e => e.Chassi)
                    .HasName("chassi");

                entity.HasIndex(e => e.CodMarca)
                    .HasName("codMarca");

                entity.Property(e => e.CodModelo).HasColumnName("codModelo");

                entity.Property(e => e.Ano)
                    .HasColumnName("ano")
                    .HasColumnType("year");

                entity.Property(e => e.Chassi)
                    .HasColumnName("chassi")
                    .HasMaxLength(10);

                entity.Property(e => e.CodMarca).HasColumnName("codMarca");

                entity.Property(e => e.Combustivel)
                    .HasColumnName("combustivel")
                    .HasMaxLength(10);

                entity.Property(e => e.Motor)
                    .HasColumnName("motor")
                    .HasMaxLength(4);

                entity.Property(e => e.Nome)
                    .HasColumnName("nome")
                    .HasMaxLength(30);

                entity.Property(e => e.Portas)
                    .HasColumnName("portas")
                    .HasMaxLength(4);

                entity.HasOne(d => d.ChassiNavigation)
                    .WithMany(p => p.Modelo)
                    .HasForeignKey(d => d.Chassi)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("modelo_ibfk_1");

                entity.HasOne(d => d.CodMarcaNavigation)
                    .WithMany(p => p.Modelo)
                    .HasForeignKey(d => d.CodMarca)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("modelo_ibfk_2");
            });

            modelBuilder.Entity<ModeloOpcional>(entity =>
            {
                entity.HasKey(e => new { e.CodModelo, e.CodOpcional })
                    .HasName("PRIMARY");

                entity.ToTable("modelo_opcional");

                entity.HasIndex(e => e.CodOpcional)
                    .HasName("codOpcional");

                entity.Property(e => e.CodModelo).HasColumnName("codModelo");

                entity.Property(e => e.CodOpcional).HasColumnName("codOpcional");

                entity.HasOne(d => d.CodModeloNavigation)
                    .WithMany(p => p.ModeloOpcional)
                    .HasForeignKey(d => d.CodModelo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("modelo_opcional_ibfk_1");

                entity.HasOne(d => d.CodOpcionalNavigation)
                    .WithMany(p => p.ModeloOpcional)
                    .HasForeignKey(d => d.CodOpcional)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("modelo_opcional_ibfk_2");
            });

            modelBuilder.Entity<Opcional>(entity =>
            {
                entity.HasKey(e => e.CodOpcional)
                    .HasName("PRIMARY");

                entity.ToTable("opcional");

                entity.Property(e => e.CodOpcional).HasColumnName("codOpcional");

                entity.Property(e => e.Nome)
                    .HasColumnName("nome")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Proprietario>(entity =>
            {
                entity.HasKey(e => e.CpfProp)
                    .HasName("PRIMARY");

                entity.ToTable("proprietario");

                entity.Property(e => e.CpfProp)
                    .HasColumnName("cpfProp")
                    .HasMaxLength(20);

                entity.Property(e => e.Cnh)
                    .HasColumnName("cnh")
                    .HasMaxLength(15);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(30);

                entity.Property(e => e.Endereço)
                    .HasColumnName("endereço")
                    .HasMaxLength(50);

                entity.Property(e => e.Idade).HasColumnName("idade");

                entity.Property(e => e.Nome)
                    .HasColumnName("nome")
                    .HasMaxLength(30);

                entity.Property(e => e.Telefone)
                    .HasColumnName("telefone")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Veiculo>(entity =>
            {
                entity.HasKey(e => e.Chassi)
                    .HasName("PRIMARY");

                entity.ToTable("veiculo");

                entity.HasIndex(e => e.CodEstado)
                    .HasName("codEstado");

                entity.HasIndex(e => e.CodModelo)
                    .HasName("codModelo");

                entity.HasIndex(e => e.CpfProp)
                    .HasName("cpfProp");

                entity.Property(e => e.Chassi)
                    .HasColumnName("chassi")
                    .HasMaxLength(10);

                entity.Property(e => e.Ano)
                    .HasColumnName("ano")
                    .HasColumnType("year");

                entity.Property(e => e.AnoLicenciamento)
                    .HasColumnName("anoLicenciamento")
                    .HasColumnType("year");

                entity.Property(e => e.CodEstado).HasColumnName("codEstado");

                entity.Property(e => e.CodModelo).HasColumnName("codModelo");

                entity.Property(e => e.CpfProp)
                    .HasColumnName("cpfProp")
                    .HasMaxLength(20);

                entity.Property(e => e.Placa)
                    .HasColumnName("placa")
                    .HasMaxLength(8);

                entity.HasOne(d => d.CodEstadoNavigation)
                    .WithMany(p => p.Veiculo)
                    .HasForeignKey(d => d.CodEstado)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("veiculo_ibfk_2");

                entity.HasOne(d => d.CodModeloNavigation)
                    .WithMany(p => p.Veiculo)
                    .HasForeignKey(d => d.CodModelo)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("veiculo_ibfk_3");

                entity.HasOne(d => d.CpfPropNavigation)
                    .WithMany(p => p.Veiculo)
                    .HasForeignKey(d => d.CpfProp)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("veiculo_ibfk_1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
