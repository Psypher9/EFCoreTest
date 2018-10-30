using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System.IO;

namespace EFCoreTest.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
        public MyDbContext() : this(new DbContextOptions<MyDbContext>())
        { }

        public DbSet<Cat> Cats { get; set; }
        public DbSet<Lizard> Lizards { get; set; }

        public static readonly LoggerFactory _Logger = new LoggerFactory(new[]
        {
            new ConsoleLoggerProvider((category, level)
            => category == DbLoggerCategory.Database.Command.Name
               && level == LogLevel.Error, true)
        });

        protected override void OnConfiguring(DbContextOptionsBuilder opts)
            => opts.UseLoggerFactory(_Logger).UseSqlServer(GetConfiguration().GetConnectionString("TestDb"));

        protected override void OnModelCreating(ModelBuilder modelBuilder)
            => base.OnModelCreating(modelBuilder);

        public IConfiguration GetConfiguration()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            return builder.Build();
        }
    }
}
