using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Ecommerce_Project.Models
{
    public partial class EStoreContext : DbContext
    {
        public EStoreContext()
        {
        }

        public EStoreContext(DbContextOptions<EStoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BrandMaster> BrandMasters { get; set; } = null!;
        public virtual DbSet<BrandType> BrandTypes { get; set; } = null!;
        public virtual DbSet<HomeProduct> HomeProducts { get; set; } = null!;
        public virtual DbSet<InOrganicProduct> InOrganicProducts { get; set; } = null!;
        public virtual DbSet<LatestProduct> LatestProducts { get; set; } = null!;
        public virtual DbSet<MensCosmoticsProduct> MensCosmoticsProducts { get; set; } = null!;
        public virtual DbSet<MensWearProduct> MensWearProducts { get; set; } = null!;
        public virtual DbSet<MobProduct> MobProducts { get; set; } = null!;
        public virtual DbSet<Option> Options { get; set; } = null!;
        public virtual DbSet<OrderTbl> OrderTbls { get; set; } = null!;
        public virtual DbSet<OrganicProduct> OrganicProducts { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<ProductMaster> ProductMasters { get; set; } = null!;
        public virtual DbSet<Review> Reviews { get; set; } = null!;
        public virtual DbSet<TrendingProduct> TrendingProducts { get; set; } = null!;
        public virtual DbSet<UserTbl> UserTbls { get; set; } = null!;
        public virtual DbSet<WmensWearProduct> WmensWearProducts { get; set; } = null!;
        public virtual DbSet<WoMensCosmoticsProduct> WoMensCosmoticsProducts { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-1J7C4G8;Database=EStore;Trusted_Connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BrandMaster>(entity =>
            {
                entity.HasKey(e => e.BrandId)
                    .HasName("PK__BrandMas__DAD4F05EFE0E64A9");

                entity.ToTable("BrandMaster");

                entity.Property(e => e.BrandName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.InternalNotes).HasColumnType("text");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.BrandMasters)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__BrandMast__Produ__1AD3FDA4");
            });

            modelBuilder.Entity<BrandType>(entity =>
            {
                entity.HasKey(e => e.BrandId)
                    .HasName("PK__BrandTyp__DAD4F05E15C2010F");

                entity.ToTable("BrandType");

                entity.Property(e => e.BrandType1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BrandType");
            });

            modelBuilder.Entity<HomeProduct>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__HomeProd__DD37D91AC576E431");

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.Pic)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<InOrganicProduct>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__InOrgani__DD37D91AB69E323C");

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.Pic)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<LatestProduct>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__LatestPr__DD37D91A9AE7B19F");

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.Pic)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<MensCosmoticsProduct>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__MensCosm__DD37D91AD97F4DDB");

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.Pic)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<MensWearProduct>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__MensWear__DD37D91A6A4FA4B2");

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.Pic)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<MobProduct>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__MobProdu__DD37D91A0EAD5A27");

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.Pic)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<Option>(entity =>
            {
                entity.ToTable("Option");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.FooterTitle)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("footerTitle");

                entity.Property(e => e.Logo)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("logo");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("mobile");

                entity.Property(e => e.SiteDesc)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("siteDesc");

                entity.Property(e => e.SiteName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("siteName");

                entity.Property(e => e.SiteTitle)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("siteTitle");
            });

            modelBuilder.Entity<OrderTbl>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK__OrderTbl__CB394B199E4A96B0");

                entity.ToTable("OrderTbl");

                entity.Property(e => e.Oid).HasColumnName("OId");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderTbls)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__OrderTbl__Produc__71D1E811");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.OrderTbls)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__OrderTbl__UserId__70DDC3D8");
            });

            modelBuilder.Entity<OrganicProduct>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__OrganicP__DD37D91AD303D782");

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.Pic)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__Product__C570593807F6ADCC");

                entity.ToTable("Product");

                entity.Property(e => e.Pic)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductMaster>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK__ProductM__B40CC6CD671A9098");

                entity.ToTable("ProductMaster");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.InternalNotes).HasColumnType("text");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Review>(entity =>
            {
                entity.ToTable("Review");

                entity.Property(e => e.Mob)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("mob");

                entity.Property(e => e.Msg)
                    .IsUnicode(false)
                    .HasColumnName("msg");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<TrendingProduct>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__Trending__DD37D91A69D5A201");

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.Pic)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<UserTbl>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PK__UserTbl__C5B69A4A0379D766");

                entity.ToTable("UserTbl");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConfrimPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Photo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WmensWearProduct>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__WmensWea__DD37D91AE1D11565");

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.Pic)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<WoMensCosmoticsProduct>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__WoMensCo__DD37D91ACAF9E350");

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.Pic)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("title");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
