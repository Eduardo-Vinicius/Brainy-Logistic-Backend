using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace backend.Models
{
    public partial class opeContext : DbContext
    {
        public opeContext()
        {
        }

        public opeContext(DbContextOptions<opeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Qtdaberta> Qtdaberta { get; set; }
        public virtual DbSet<Qtdfechada> Qtdfechada { get; set; }
        public virtual DbSet<TbCliente> TbCliente { get; set; }
        public virtual DbSet<TbCompra> TbCompra { get; set; }
        public virtual DbSet<TbFornecedor> TbFornecedor { get; set; }
        public virtual DbSet<TbFuncionario> TbFuncionario { get; set; }
        public virtual DbSet<TbOrdemServico> TbOrdemServico { get; set; }
        public virtual DbSet<TbOrdemServicoItem> TbOrdemServicoItem { get; set; }
        public virtual DbSet<TbProduto> TbProduto { get; set; }
        public virtual DbSet<TbVenda> TbVenda { get; set; }
        public virtual DbSet<TbVendaItem> TbVendaItem { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                // optionsBuilder.UseMySql("server=localhost;user id=root;password=1234@;database=ope", x => x.ServerVersion("5.7.25-mysql"));
                optionsBuilder.UseMySql("server=us-cdbr-east-02.cleardb.com;user id=bb07ffb68e4b87;password=9af223f5;database=heroku_26d209df4383276", x => x.ServerVersion("5.7.25-mysql"));
                // optionsBuilder.UseMySql("server=localhost;user id=root;password=digital4747;database=ope", x => x.ServerVersion("5.7.25-mysql"));

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Qtdaberta>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("qtdaberta");
            });

            modelBuilder.Entity<Qtdfechada>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("qtdfechada");
            });

            modelBuilder.Entity<TbCliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PRIMARY");

                entity.Property(e => e.DsBairro)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsBicicleta)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsCep)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsCpf)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsEmail)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsEndereco)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsLocalidade)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsNumero)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsRg)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsTelefone)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsUf)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NmCliente)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<TbCompra>(entity =>
            {
                entity.HasKey(e => e.IdCompra)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdFornecedor)
                    .HasName("tb_compra_fk0");

                entity.HasIndex(e => e.IdFuncionario)
                    .HasName("tb_compra_fk1");

                entity.Property(e => e.DsMarca)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NmProduto)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.HasOne(d => d.IdFornecedorNavigation)
                    .WithMany(p => p.TbCompra)
                    .HasForeignKey(d => d.IdFornecedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tb_compra_fk0");

                entity.HasOne(d => d.IdFuncionarioNavigation)
                    .WithMany(p => p.TbCompra)
                    .HasForeignKey(d => d.IdFuncionario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tb_compra_fk1");
            });

            modelBuilder.Entity<TbFornecedor>(entity =>
            {
                entity.HasKey(e => e.IdFornecedor)
                    .HasName("PRIMARY");

                entity.Property(e => e.DsBairro)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsCep)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsCnpj)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsContato)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsEmail)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsEndereco)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsLocalidade)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsNumero)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsRazaosocial)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsTelefone)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsUf)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NmFornecedor)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<TbFuncionario>(entity =>
            {
                entity.HasKey(e => e.IdFuncionario)
                    .HasName("PRIMARY");

                entity.Property(e => e.DsBairro)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsCargo)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsCep)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsCpf)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsEmail)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsEndereco)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsLocalidade)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsNumero)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsRg)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsSenha)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsTelefone)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DsUf)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NmFuncionario)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NmUsuario)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<TbOrdemServico>(entity =>
            {
                entity.HasKey(e => e.IdOrdemServico)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdCliente)
                    .HasName("tb_ordem_servico_fk1");

                entity.HasIndex(e => e.IdFuncionario)
                    .HasName("tb_ordem_servico_fk0");

                entity.Property(e => e.DsStatus)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbOrdemServico)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tb_ordem_servico_fk1");

                entity.HasOne(d => d.IdFuncionarioNavigation)
                    .WithMany(p => p.TbOrdemServico)
                    .HasForeignKey(d => d.IdFuncionario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tb_ordem_servico_fk0");
            });

            modelBuilder.Entity<TbOrdemServicoItem>(entity =>
            {
                entity.HasKey(e => e.IdOrdemServicoItem)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdOrdemServico)
                    .HasName("tb_ordem_servico_item_fk0");

                entity.HasIndex(e => e.IdProduto)
                    .HasName("tb_ordem_servico_item_fk1");

                entity.HasOne(d => d.IdOrdemServicoNavigation)
                    .WithMany(p => p.TbOrdemServicoItem)
                    .HasForeignKey(d => d.IdOrdemServico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tb_ordem_servico_item_fk0");

                entity.HasOne(d => d.IdProdutoNavigation)
                    .WithMany(p => p.TbOrdemServicoItem)
                    .HasForeignKey(d => d.IdProduto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tb_ordem_servico_item_fk1");
            });

            modelBuilder.Entity<TbProduto>(entity =>
            {
                entity.HasKey(e => e.IdProduto)
                    .HasName("PRIMARY");

                entity.Property(e => e.DsMarca)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NmProduto)
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<TbVenda>(entity =>
            {
                entity.HasKey(e => e.IdVenda)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdCliente)
                    .HasName("tb_venda_fk0");

                entity.HasIndex(e => e.IdFuncionario)
                    .HasName("tb_venda_fk1");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbVenda)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tb_venda_fk0");

                entity.HasOne(d => d.IdFuncionarioNavigation)
                    .WithMany(p => p.TbVenda)
                    .HasForeignKey(d => d.IdFuncionario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tb_venda_fk1");
            });

            modelBuilder.Entity<TbVendaItem>(entity =>
            {
                entity.HasKey(e => e.IdVendaItem)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdProduto)
                    .HasName("tb_venda_item_fk0");

                entity.HasIndex(e => e.IdVenda)
                    .HasName("tb_venda_item_fk1");

                entity.HasOne(d => d.IdProdutoNavigation)
                    .WithMany(p => p.TbVendaItem)
                    .HasForeignKey(d => d.IdProduto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tb_venda_item_fk0");

                entity.HasOne(d => d.IdVendaNavigation)
                    .WithMany(p => p.TbVendaItem)
                    .HasForeignKey(d => d.IdVenda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tb_venda_item_fk1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
