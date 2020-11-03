using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ClassLibrary.Models
{
    public partial class BCSoftwareDBContext : IdentityDbContext<AppUsers, AppRoles, int>
    {
        public BCSoftwareDBContext()
        {
        }

        public BCSoftwareDBContext(DbContextOptions<BCSoftwareDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Batch> Batch { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Donation> Donation { get; set; }
        public virtual DbSet<DonationStatus> DonationStatus { get; set; }
        public virtual DbSet<Donor> Donor { get; set; }
        public virtual DbSet<Fund> Fund { get; set; }
        public virtual DbSet<Organization> Organization { get; set; }
        public virtual DbSet<OrganizationType> OrganizationType { get; set; }
        public virtual DbSet<Profession> Profession { get; set; }
        public virtual DbSet<SoftwareVersion> SoftwareVersion { get; set; }
        public virtual DbSet<Tree> Tree { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        public virtual DbSet<XcadetUser> XcadetUser { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        //        optionsBuilder.UseSqlServer("server=.;uid=bestowers;password=Iloveboy1;database=BCSoftwareDB");
        //    }
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AppUsers>().ToTable("AppUsers", "dbo");
            modelBuilder.Entity<AppRoles>().ToTable("AppRoles", "dbo");
            //modelBuilder.Entity<IdentityRole>().ToTable("AppRoles", "dbo").Property(p => p.Id).HasColumnName("Id");
            modelBuilder.Entity<IdentityUserRole<int>>().ToTable("AppUserRoles", "dbo");
            modelBuilder.Entity<IdentityUserLogin<int>>().ToTable("AppUserLogins", "dbo");
            modelBuilder.Entity<IdentityUserClaim<int>>().ToTable("AppUserClaims", "dbo");
            modelBuilder.Entity<IdentityRoleClaim<int>>().ToTable("AppRoleClaims", "dbo");
            modelBuilder.Entity<IdentityUserToken<int>>().ToTable("AppUserTokens", "dbo");

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
