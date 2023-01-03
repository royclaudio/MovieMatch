using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MovieMauiAPI.Models;

namespace FilmFinderApi.Data
{
	public class ApplicationDbContext : DbContext
    {
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<MovieCatalogModel> MovieCatalog => Set<MovieCatalogModel>();
        public DbSet<UserAverageFeaturesModel> UserAverageFeatures => Set<UserAverageFeaturesModel>();
        public DbSet<UserFeaturesModel> UserFeatures => Set<UserFeaturesModel>();
        public DbSet<UserModel> Users => Set<UserModel>();
        public DbSet<UserRatingsModel> UserRatings => Set<UserRatingsModel>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new SeedDataTestUser());
            modelBuilder.ApplyConfiguration(new SeedDataMovieData());

        }

    }
}

