namespace Jester.Data;

using Jester.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

public class NewsContext : DbContext
{

    protected readonly IConfiguration Configuration;

    public NewsContext(DbContextOptions<NewsContext> options, IConfiguration configuration) : base(options) {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"));
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<NewsItem>()
        .Property(e => e.DatePublished)
        .HasConversion(new ValueConverter<DateTime, DateTime>(
            v => v.ToUniversalTime(),
            v => DateTime.SpecifyKind(v, DateTimeKind.Utc)));

        base.OnModelCreating(modelBuilder);

        modelBuilder.Seed();
    }

    public DbSet<NewsItem> NewsItems { get; set; }


}
