using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace test.Models
{
    public partial class devcustomapplogprocessordbContext : DbContext
    {
        public devcustomapplogprocessordbContext()
        {
        }

        public devcustomapplogprocessordbContext(DbContextOptions<devcustomapplogprocessordbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DataLoader> DataLoader { get; set; }
        public virtual DbSet<TimeIntervalExceptions> TimeIntervalExceptions { get; set; }

//         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//         {
//             if (!optionsBuilder.IsConfigured)
//             {
// #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                 optionsBuilder.UseSqlServer("Server=dev-customapplogprocessosqlsvr.database.windows.net;Database=dev-customapplogprocessordb;UID=Devappadmin;PWD=P3et$$qL@dm!nd3v;Integrated Security=false");
//             }
//         }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<DataLoader>(entity =>
            {
                entity.Property(e => e.CommonStatus).HasMaxLength(50);

                entity.Property(e => e.EndTime).HasMaxLength(50);

                entity.Property(e => e.EnqueuedTime)
                    .HasColumnName("enqueuedTime")
                    .HasMaxLength(50);

                entity.Property(e => e.JobId)
                    .IsRequired()
                    .HasColumnName("JobID")
                    .HasMaxLength(500);

                entity.Property(e => e.JobName).HasMaxLength(500);

                entity.Property(e => e.Source).HasMaxLength(50);

                entity.Property(e => e.StartTime).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.TaskName).HasMaxLength(500);

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("timeStamp")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TimeIntervalExceptions>(entity =>
            {
                entity.Property(e => e.Source).HasMaxLength(50);

                entity.Property(e => e.StartTime)
                    .HasColumnName("startTime")
                    .HasMaxLength(50);
            });
        }
    }
}
