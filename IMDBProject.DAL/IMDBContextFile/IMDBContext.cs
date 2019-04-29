namespace IMDBProject.DAL.IMDBContextFile
{
    using IMDBProject.Entities.Models;
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class IMDBContext : DbContext
    {
        public IMDBContext() : base("IMDBContext")
        {
        }

        public virtual DbSet<Actor> Actor { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Director> Director { get; set; }
        public virtual DbSet<Film> Film { get; set; }
        public virtual DbSet<Language> Language { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<Rating> Rating { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor>()
                .HasMany(e => e.Film)
                .WithMany(e => e.Actor)
                .Map(m => m.ToTable("Film_Actor").MapLeftKey("ActorID").MapRightKey("FilmID"));

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Film)
                .WithMany(e => e.Category)
                .Map(m => m.ToTable("Film_Category").MapLeftKey("CategoryID").MapRightKey("FilmID"));

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Actor)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Director)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Film)
                .WithMany(e => e.Country)
                .Map(m => m.ToTable("Film_Country").MapLeftKey("CountryID").MapRightKey("FilmID"));

            modelBuilder.Entity<Director>()
                .HasMany(e => e.Film)
                .WithMany(e => e.Director)
                .Map(m => m.ToTable("Film_Director").MapLeftKey("DirectorID").MapRightKey("FilmID"));

            modelBuilder.Entity<Language>()
                .HasMany(e => e.Film)
                .WithRequired(e => e.Language)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Login)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Rating)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}
