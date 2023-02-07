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
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
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
