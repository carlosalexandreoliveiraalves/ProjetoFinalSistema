using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore.Extensions;

namespace mysqlefcore
{
  public class ClientContext : DbContext
  {
    public DbSet<Usuario>? Usuario { get; set; }

    public DbSet<Duvida>? Duvida { get; set; }
    public DbSet<Reclamacao>? Reclamacao { get; set; }
    public DbSet<Problema>? Problema { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseMySQL("server=localhost;database=clientmanager3;user=root;password=root");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      modelBuilder.Entity<Duvida>(entity =>
      {
        entity.HasKey(e => e.id);
        entity.Property(e => e.desc).IsRequired();
        entity.Property(e => e.id_usuario_duvida );
        entity.HasOne(d => d.Usuario)
          .WithMany(p => p.Duvidas).HasForeignKey(e => e.id_usuario_duvida);;
      });

      modelBuilder.Entity<Reclamacao>(entity =>
      {
        entity.HasKey(e => e.id);
        entity.Property(e => e.desc).IsRequired();
        entity.Property(e => e.data);
        entity.Property(e => e.id_usuario_reclamacoes);
        entity.HasOne(d => d.Usuario)
          .WithMany(p => p.Reclamacoes).HasForeignKey(e => e.id_usuario_reclamacoes);;
      });


      modelBuilder.Entity<Problema>(entity =>
      {
        entity.HasKey(e => e.id);
        entity.Property(e => e.desc).IsRequired();
        entity.Property(e => e.data);
        entity.Property(e => e.id_usuario_problema);
        entity.HasOne(d => d.Usuario)
          .WithMany(p => p.Problemas).HasForeignKey(e => e.id_usuario_problema);;
      });

      modelBuilder.Entity<Usuario>(entity =>
      {
        entity.HasKey(e => e.id);
        entity.Property(e => e.nome).IsRequired();
      });
    }
  }
}