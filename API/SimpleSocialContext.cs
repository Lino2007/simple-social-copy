using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API;

public partial class SimpleSocialContext : DbContext
{
    public SimpleSocialContext()
    {
    }

    public SimpleSocialContext(DbContextOptions<SimpleSocialContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; } = null!;
    public virtual DbSet<Comment> Comments { get; set; } = null!;
    public virtual DbSet<Permission> Permissions { get; set; } = null!;
    public virtual DbSet<Person> People { get; set; } = null!;
    public virtual DbSet<PersonAuth> PersonAuths { get; set; } = null!;
    public virtual DbSet<PersonBan> PersonBans { get; set; } = null!;
    public virtual DbSet<Post> Posts { get; set; } = null!;
    public virtual DbSet<Report> Reports { get; set; } = null!;
    public virtual DbSet<Role> Roles { get; set; } = null!;
    public virtual DbSet<RolePermission> RolePermissions { get; set; } = null!;
    public virtual DbSet<Star> Stars { get; set; } = null!;
    public virtual DbSet<UserRole> UserRoles { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Name=ConnectionStrings:SimpleSocial");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasOne(d => d.ForumCreatorNavigation)
                .WithMany(p => p.Categories)
                .HasForeignKey(d => d.ForumCreator)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKCategory446984");
        });

        modelBuilder.Entity<Comment>(entity =>
        {
            entity.HasOne(d => d.Author)
                .WithMany(p => p.Comments)
                .HasForeignKey(d => d.AuthorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKComment47829");

            entity.HasOne(d => d.Post)
                .WithMany(p => p.Comments)
                .HasForeignKey(d => d.PostId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKComment963939");
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasOne<PersonAuth>(d => d.PersonAuth)
                .WithOne(p => p.Person)
                .HasForeignKey<Person>(d => d.PersonAuthId)
                .HasConstraintName("FKPerson499624");
        });

        modelBuilder.Entity<PersonBan>(entity =>
        {
            entity.HasOne(d => d.Person)
                .WithMany(p => p.PersonBans)
                .HasForeignKey(d => d.PersonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKPersonBan89003");
        });

        modelBuilder.Entity<Post>(entity =>
        {
            entity.Property(e => e.Locked).HasDefaultValueSql("('0')");

            entity.HasOne(d => d.Category)
                .WithMany(p => p.Posts)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKPost321029");
        });

        modelBuilder.Entity<Report>(entity =>
        {
            entity.HasOne(d => d.Comment)
                .WithMany(p => p.Reports)
                .HasForeignKey(d => d.CommentId)
                .HasConstraintName("FKReport352513");

            entity.HasOne(d => d.Post)
                .WithMany(p => p.Reports)
                .HasForeignKey(d => d.PostId)
                .HasConstraintName("FKReport224814");
        });

        modelBuilder.Entity<RolePermission>(entity =>
        {
            entity.HasOne(d => d.Permission)
                .WithMany(p => p.RolePermissions)
                .HasForeignKey(d => d.PermissionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKRolePermis384465");

            entity.HasOne(d => d.Roles)
                .WithMany(p => p.RolePermissions)
                .HasForeignKey(d => d.RolesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKRolePermis536657");
        });

        modelBuilder.Entity<Star>(entity =>
        {
            entity.HasOne(d => d.Comment)
                .WithMany(p => p.Stars)
                .HasForeignKey(d => d.CommentId)
                .HasConstraintName("FKStar375562");

            entity.HasOne(d => d.Person)
                .WithMany(p => p.Stars)
                .HasForeignKey(d => d.PersonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKStar453603");

            entity.HasOne(d => d.Post)
                .WithMany(p => p.Stars)
                .HasForeignKey(d => d.PostId)
                .HasConstraintName("FKStar503293");
        });

        modelBuilder.Entity<UserRole>(entity =>
        {
            entity.HasOne(d => d.Person)
                .WithMany(p => p.UserRoles)
                .HasForeignKey(d => d.PersonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKUserRole931104");

            entity.HasOne(d => d.Role)
                .WithMany(p => p.UserRoles)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKUserRole886037");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

