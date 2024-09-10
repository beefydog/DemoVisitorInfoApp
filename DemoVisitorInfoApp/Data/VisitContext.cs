using Microsoft.EntityFrameworkCore;

namespace DemoVisitorInfoApp.Data
{
    public class VisitContext(DbContextOptions<VisitContext> options) : DbContext(options)
    {
        public DbSet<Visit> Visits { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Visit>(entity =>
            {
                entity.Property(e => e.IPAddress).HasColumnType("varchar(45)");
                entity.Property(e => e.Browser).HasColumnType("nvarchar(500)");
                entity.Property(e => e.OperatingSystem).HasColumnType("varchar(40)");
                entity.Property(e => e.DeviceType).HasColumnType("varchar(40)");
                entity.Property(e => e.ScreenResolution).HasColumnType("varchar(11)");
                entity.Property(e => e.ReferrerUrl).HasColumnType("nvarchar(2048)");
                entity.Property(e => e.SessionId).HasColumnType("varchar(100)");
                entity.Property(e => e.Cookies).HasColumnType("nvarchar(max)");
                entity.Property(e => e.LastPath).HasColumnType("nvarchar(2048)");
                entity.Property(e => e.LastQueryString).HasColumnType("nvarchar(2048)");
                entity.Property(e => e.LastReferrerUrl).HasColumnType("nvarchar(2048)");
                entity.Property(e => e.Path).HasColumnType("nvarchar(2048)");
                entity.Property(e => e.QueryString).HasColumnType("nvarchar(2048)");
            });
        }
    }
}
