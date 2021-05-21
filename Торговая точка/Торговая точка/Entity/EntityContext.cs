namespace Торговая_точка.Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EntityContext : DbContext
    {
        public EntityContext()
            : base("name=EntityContext")
        {
        }

        public virtual DbSet<Mestopologeniye> Mestopologeniye { get; set; }
        public virtual DbSet<Orgnizaciya> Orgnizaciya { get; set; }
        public virtual DbSet<Postavshik> Postavshik { get; set; }
        public virtual DbSet<Prodovec> Prodovec { get; set; }
        public virtual DbSet<Tochka> Tochka { get; set; }
        public virtual DbSet<Tovar> Tovar { get; set; }
        public virtual DbSet<ZakazyPostavshikam> ZakazyPostavshikam { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Orgnizaciya>()
                .HasMany(e => e.Mestopologeniye)
                .WithRequired(e => e.Orgnizaciya)
                .HasForeignKey(e => e.id_organizaciya)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Orgnizaciya>()
                .HasMany(e => e.Tochka)
                .WithRequired(e => e.Orgnizaciya)
                .HasForeignKey(e => e.id_organizacia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Orgnizaciya>()
                .HasMany(e => e.ZakazyPostavshikam)
                .WithRequired(e => e.Orgnizaciya)
                .HasForeignKey(e => e.id_organizacia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Postavshik>()
                .HasMany(e => e.ZakazyPostavshikam)
                .WithRequired(e => e.Postavshik)
                .HasForeignKey(e => e.id_postavshiki)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tochka>()
                .HasMany(e => e.Mestopologeniye)
                .WithRequired(e => e.Tochka)
                .HasForeignKey(e => e.id_tochka)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tochka>()
                .HasMany(e => e.Prodovec)
                .WithRequired(e => e.Tochka)
                .HasForeignKey(e => e.id_tochka)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tovar>()
                .Property(e => e.cena)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tovar>()
                .HasMany(e => e.ZakazyPostavshikam)
                .WithRequired(e => e.Tovar)
                .HasForeignKey(e => e.id_tovar)
                .WillCascadeOnDelete(false);
        }
    }
}
