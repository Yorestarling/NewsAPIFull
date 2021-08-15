using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using APInewsREST.Models;

#nullable disable

namespace APInewsREST.Data
{
    public partial class NewsAPIsideContext : DbContext
    {
        public NewsAPIsideContext()
        {
        }

        public NewsAPIsideContext(DbContextOptions<NewsAPIsideContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Source> Sources { get; set; }
        public virtual DbSet<UsersLog> UsersLogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=Y-ODESKTOP;Initial Catalog=NewsAPIside;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Article>(entity =>
            {
                entity.HasOne(d => d.Author)
                    .WithMany(p => p.Articles)
                    .HasForeignKey(d => d.AuthorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AuthorIds");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Articles)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CategoryId");

                entity.HasOne(d => d.Countries)
                    .WithMany(p => p.Articles)
                    .HasForeignKey(d => d.CountriesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CountriesId");

                entity.HasOne(d => d.Sources)
                    .WithMany(p => p.Articles)
                    .HasForeignKey(d => d.SourcesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SourcesIds");
            });

            modelBuilder.Entity<Author>(entity =>
            {
                entity.Property(e => e.AuthorName).IsUnicode(false);

                entity.HasOne(d => d.Users)
                    .WithMany(p => p.Authors)
                    .HasForeignKey(d => d.UsersId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserId");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CategoryName).IsUnicode(false);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => e.CountriesId)
                    .HasName("PK_CountriesId");

                entity.Property(e => e.ContriesName).IsUnicode(false);
            });

            modelBuilder.Entity<Source>(entity =>
            {
                entity.HasKey(e => e.SourcesId)
                    .HasName("PK_SourcesId");

                entity.Property(e => e.SourcesName).IsUnicode(false);
            });

            modelBuilder.Entity<UsersLog>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK_UserId");

                entity.Property(e => e.DisplayName).IsUnicode(false);

                entity.Property(e => e.Passwords).IsUnicode(false);

                entity.Property(e => e.Username).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
