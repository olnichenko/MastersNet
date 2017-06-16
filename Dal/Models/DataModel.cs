namespace Dal.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataModel : DbContext
    {
        public DataModel()
            : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Speciality> Specialities { get; set; }
        public virtual DbSet<SpecialityesToAd> SpecialityesToAds { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<TagsToAd> TagsToAds { get; set; }
        public virtual DbSet<Аdvertisement> Аdvertisement { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRole>()
                .HasMany(e => e.AspNetUsers)
                .WithMany(e => e.AspNetRoles)
                .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.Аdvertisement)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserCreatedId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.Аdvertisement1)
                .WithOptional(e => e.AspNetUser1)
                .HasForeignKey(e => e.UserUpdatedId);

            modelBuilder.Entity<Speciality>()
                .HasMany(e => e.SpecialityesToAds)
                .WithRequired(e => e.Speciality)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tag>()
                .HasMany(e => e.TagsToAds)
                .WithRequired(e => e.Tag)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Аdvertisement>()
                .HasMany(e => e.SpecialityesToAds)
                .WithRequired(e => e.Аdvertisement)
                .HasForeignKey(e => e.AdId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Аdvertisement>()
                .HasMany(e => e.TagsToAds)
                .WithRequired(e => e.Аdvertisement)
                .HasForeignKey(e => e.AdId)
                .WillCascadeOnDelete(false);
        }
    }
}
