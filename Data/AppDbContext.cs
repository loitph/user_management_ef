
using Microsoft.EntityFrameworkCore;
using user_management_ef.Models;

namespace user_management_ef.Data;

public class AppDbContext: DbContext
{
  public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
  public DbSet<User> Users => Set<User>();

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<User>(entity =>
    {
      entity.HasKey(e => e.Id);

      entity.Property(e => e.Name)
        .IsRequired()
        .HasMaxLength(100);

      entity.Property(e => e.Email)
        .IsRequired()
        .HasMaxLength(150);

      entity.Property(e => e.Description)
        .HasMaxLength(500);

      entity.Property(e => e.Deleted)
        .HasDefaultValue(false);
    });
  }
}