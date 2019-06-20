using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using summer19.Model;

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

        public virtual DbSet<Candidate> Candidate { get; set; }
        public virtual DbSet<DataFile> DataFile { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<Requirements> Requirements { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=INBD01SR135;Database=corporate1;user id=dev_internship;password=ibinternship_dev;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Candidate>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address1)
                    .HasColumnName("address1")
                    .HasMaxLength(100);

                entity.Property(e => e.Address2)
                    .HasColumnName("address2")
                    .HasMaxLength(100);

                entity.Property(e => e.Cell)
                    .HasColumnName("cell")
                    .HasMaxLength(15);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(30);

                entity.Property(e => e.Comptetenices)
                    .HasColumnName("comptetenices")
                    .HasMaxLength(100);

                entity.Property(e => e.Country).HasMaxLength(30);

                entity.Property(e => e.Departement).HasMaxLength(30);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100);

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(30);

                entity.Property(e => e.Feedback).HasMaxLength(100);

                entity.Property(e => e.Firstname)
                    .HasColumnName("firstname")
                    .HasMaxLength(15);

                entity.Property(e => e.Hire)
                    .HasColumnName("hire")
                    .HasMaxLength(10);

                entity.Property(e => e.Home)
                    .HasColumnName("home")
                    .HasMaxLength(15);

                entity.Property(e => e.Jobcategory)
                    .HasColumnName("jobcategory")
                    .HasMaxLength(50);

                entity.Property(e => e.Jobtitle)
                    .HasColumnName("jobtitle")
                    .HasMaxLength(15);

                entity.Property(e => e.Lastname)
                    .HasColumnName("lastname")
                    .HasMaxLength(15);

                entity.Property(e => e.Middlename)
                    .HasColumnName("middlename")
                    .HasMaxLength(15);

                entity.Property(e => e.Resumeupload).HasMaxLength(100);

                entity.Property(e => e.Source)
                    .HasColumnName("source")
                    .HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.Zip).HasColumnName("zip");
            });

            modelBuilder.Entity<DataFile>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Extension).HasMaxLength(500);

                entity.Property(e => e.Path).HasColumnName("path");
            });

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

        public DbSet<summer19.Model.Filter> Filter { get; set; }
    }
}
