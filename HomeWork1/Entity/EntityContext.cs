using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace HomeWork1.Entity
{
    public partial class EntityContext : DbContext
    {
        public EntityContext()
            : base("name=EntityContext")
        {
        }

        public virtual DbSet<clients> clients { get; set; }
        public virtual DbSet<managers> managers { get; set; }
        public virtual DbSet<order> order { get; set; }
        public virtual DbSet<products> products { get; set; }
        public virtual DbSet<user> user { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<clients>()
                .HasMany(e => e.order)
                .WithRequired(e => e.clients)
                .HasForeignKey(e => e.clientId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<order>()
                .HasMany(e => e.products)
                .WithMany(e => e.order)
                .Map(m => m.ToTable("listOfProductsInOrder").MapLeftKey("OrderId").MapRightKey("ProductId"));

            modelBuilder.Entity<products>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<user>()
                .HasMany(e => e.clients)
                .WithRequired(e => e.user)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<user>()
                .HasMany(e => e.managers)
                .WithRequired(e => e.user)
                .WillCascadeOnDelete(false);
        }
    }
}
