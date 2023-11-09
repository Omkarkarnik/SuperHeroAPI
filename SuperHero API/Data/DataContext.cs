using System;
namespace SuperHero_API.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{

		}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=localhost;Database=superherodb;TrustServerCertificate=true;User=sa;Password=Darkemperor@619");

        }

        public DbSet<SuperHero> SuperHeroes { get; set; }
    } 

}