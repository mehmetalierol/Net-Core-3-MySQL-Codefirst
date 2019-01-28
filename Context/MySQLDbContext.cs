using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Net_Core_3_MySQL_Codefirst.Entites;

namespace Net_Core_3_MySQL_Codefirst.Context
{
    public class MySQLDbContext : DbContext
    {
        #region Constructor

        public MySQLDbContext()
        {

        }

        #endregion Constructor

        #region ModelCreating

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        #endregion ModelCreating

        #region OnConfiguring

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            optionsBuilder.UseMySql(config.GetConnectionString("DefaultConnection"));
        }

        #endregion OnConfiguring

        #region DbSets

        public DbSet<EntityUser> EntityUser { get; set; }
        public DbSet<EntityRole> EntityRole { get; set; }
        public DbSet<EntityUserRole> EntityUserRole { get; set; }

        #endregion DbSets

    }
}
