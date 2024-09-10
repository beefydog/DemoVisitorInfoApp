using Microsoft.EntityFrameworkCore;

namespace DemoVisitorInfoApp.Data;

public class VisitContext(DbContextOptions<VisitContext> options) : DbContext(options)
{
    public DbSet<Visit> Visits { get; set; }
}
