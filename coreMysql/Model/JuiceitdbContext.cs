using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace coreMysql.Model
{
    public partial class JuiceitdbContext : DbContext
    {
        public virtual DbSet<Bug> Bug { get; set; }
        public virtual DbSet<Bugjuice> Bugjuice { get; set; }
        public virtual DbSet<Cart> Cart { get; set; }
        public virtual DbSet<Favourite> Favourite { get; set; }
        public virtual DbSet<Juice> Juice { get; set; }
        public virtual DbSet<Mixture> Mixture { get; set; }
        public virtual DbSet<Paymentmode> Paymentmode { get; set; }
        public virtual DbSet<Preference> Preference { get; set; }
        public virtual DbSet<Resource> Resource { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Verificationcode> Verificationcode { get; set; }

		public JuiceitdbContext(DbContextOptions<JuiceitdbContext> options):base(options){}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
				optionsBuilder.UseMySql("server=ec2-54-213-118-72.us-west-2.compute.amazonaws.com;port=3306;user=root;password=moksha;database=juiceitdb;SslMode=none");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bug>(entity =>
            {
                entity.ToTable("bug");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("varchar(10000)");

                entity.Property(e => e.IsPopular)
                    .HasColumnName("isPopular")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Bugjuice>(entity =>
            {
                entity.ToTable("bugjuice");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Bugid)
                    .HasColumnName("bugid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Juiceid)
                    .HasColumnName("juiceid")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Cart>(entity =>
            {
                entity.ToTable("cart");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Juiceid)
                    .HasColumnName("juiceid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OrderedDate)
                    .HasColumnName("orderedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Favourite>(entity =>
            {
                entity.ToTable("favourite");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Juiceid)
                    .HasColumnName("juiceid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Juice>(entity =>
            {
                entity.ToTable("juice");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsSingle)
                    .HasColumnName("isSingle")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(10,2)");
            });

            modelBuilder.Entity<Mixture>(entity =>
            {
                entity.ToTable("mixture");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Juiceid)
                    .HasColumnName("juiceid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("decimal(10,4)");

                entity.Property(e => e.Resourceid)
                    .HasColumnName("resourceid")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Paymentmode>(entity =>
            {
                entity.ToTable("paymentmode");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<Preference>(entity =>
            {
                entity.ToTable("preference");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Bugid)
                    .HasColumnName("bugid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsActive)
                    .HasColumnName("isActive")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Resource>(entity =>
            {
                entity.ToTable("resource");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Imageuri)
                    .HasColumnName("imageuri")
                    .HasMaxLength(450);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AuthToken)
                    .HasColumnName("authToken")
                    .HasMaxLength(255);

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100);

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Mobileno)
                    .HasColumnName("mobileno")
                    .HasMaxLength(15);

                entity.Property(e => e.Modifiedon)
                    .HasColumnName("modifiedon")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(450);

                entity.Property(e => e.Salt)
                    .HasColumnName("salt")
                    .HasMaxLength(450);
            });

            modelBuilder.Entity<Verificationcode>(entity =>
            {
                entity.ToTable("verificationcode");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(10);

                entity.Property(e => e.Expirydate)
                    .HasColumnName("expirydate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Mobileno)
                    .HasColumnName("mobileno")
                    .HasMaxLength(15);
            });
        }
    }
}
