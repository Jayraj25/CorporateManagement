using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace summer19.Model
{
    public partial class corporate1Context : DbContext
    {
        public corporate1Context()
        {
        }

        public corporate1Context(DbContextOptions<corporate1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<Requirements> Requirements { get; set; }
        public Task Requirement { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=INBD01SR135;Database=corporate1;user id=dev_internship;password=ibinternship_dev;MultipleActiveResultSets=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Login>(entity =>
            {
                entity.ToTable("login");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(10);

                entity.Property(e => e.Remember)
                    .HasColumnName("remember")
                    .HasMaxLength(10);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Requirements>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comments).HasMaxLength(100);

                entity.Property(e => e.Departement)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Skills).IsRequired();

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(60);
            });
        }
    }
}
