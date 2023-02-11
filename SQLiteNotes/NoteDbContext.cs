using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SQLiteNotes;

public partial class NoteDbContext : DbContext
{
    public NoteDbContext()
    {
    }

    public NoteDbContext(DbContextOptions<NoteDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Note> Notes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=C:\\\\\\\\Users\\\\\\\\Admin\\\\\\\\DB Browser for SQLite\\\\\\\\DataBases\\\\\\\\NoteDB.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Note>(entity =>
        {
            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.FontFamily).HasDefaultValueSql("'Times New Roman'");
            entity.Property(e => e.FontSize).HasDefaultValueSql("14");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
