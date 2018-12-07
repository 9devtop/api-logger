using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LoggerAPI
{
    public partial class _9devlogdbContext : DbContext
    {
        public _9devlogdbContext()
        {
        }

        public _9devlogdbContext(DbContextOptions<_9devlogdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CalLog> CalLog { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:9dev.database.windows.net,1433;Initial Catalog=9devlogdb;Persist Security Info=False;User ID=ninedev;Password=Nine!Dev;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CalLog>(entity =>
            {
                entity.Property(e => e.Kq).HasColumnName("KQ");

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");
            });
        }
    }
}
