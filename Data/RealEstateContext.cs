using Microsoft.EntityFrameworkCore;
using RealEstateWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateWebApp.Data
{
    public class RealEstateContext : DbContext
    {
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<Listing> Listings { get; set; }
        public DbSet<Photo> Photos { get; set; }


        public RealEstateContext(DbContextOptions<RealEstateContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FavoritedListing>()
                .HasKey(f => new { f.ProfileId, f.ListingId });

            modelBuilder.Entity<FavoritedListing>()
                .HasOne(f => f.Profile)
                .WithMany(p => p.FavoritedListings)
                .HasForeignKey(f => f.ProfileId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<FavoritedListing>()
                .HasOne(f => f.Listing)
                .WithMany(p => p.ProfilesWhoFavorited)
                .HasForeignKey(f => f.ListingId);
        }
    }
}
