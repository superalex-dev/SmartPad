using Microsoft.EntityFrameworkCore;
using SmartPad.Models;

public class NotesContext : DbContext
{
    public DbSet<ActiveNote> ActiveNotes { get; set; }
    public DbSet<ArchivedNote> ArchivedNotes { get; set; }

    public NotesContext(DbContextOptions<NotesContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ActiveNote>()
            .HasIndex(a => a.Id)
            .IsUnique();
        modelBuilder.Entity<ArchivedNote>()
            .HasIndex(d => d.Id)
            .IsUnique();
    }
}