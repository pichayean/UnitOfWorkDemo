using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace UnitOfWorkDemo.Repository.Models
{
    public partial class pichayea_doitContext : DbContext
    {
        public pichayea_doitContext()
        {
        }

        public pichayea_doitContext(DbContextOptions<pichayea_doitContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Doit> Doit { get; set; }
        public virtual DbSet<Doit2> Doit2 { get; set; }
        public virtual DbSet<Test> Test { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=119.59.96.60\\MSSQLSERVER2016;Database=pichayea_doit;User ID=macus;Password=p@ssw0rdasdf;Trusted_Connection=True;Persist Security Info=False;Integrated Security=false;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:DefaultSchema", "macus");

            modelBuilder.Entity<Doit>(entity =>
            {
                entity.ToTable("doit", "doit");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Msg).HasColumnName("msg");
            });

            modelBuilder.Entity<Doit2>(entity =>
            {
                entity.ToTable("doit2", "doit");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Msg).HasColumnName("msg");
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.HasKey(e => e.PersonId);

                entity.ToTable("Test", "doit");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });
        }
    }
}
