using Microsoft.EntityFrameworkCore;

namespace backend.Entities;

public class BackendDbContext : DbContext {
    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        base.OnConfiguring(optionsBuilder);
    }
}