using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RealEstateWebApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateWebApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RealEstateContext(serviceProvider.GetRequiredService<DbContextOptions<RealEstateContext>>()))
            {
                if (context.Properties.Any())
                {
                    return;
                }

                var profiles = new Profile[]
                {
                    new Profile
                    {
                        Username = "User1",
                        Password = "password1"
                    },
                    new Profile
                    {
                        Username = "User2",
                        Password = "password2"
                    },
                    new Profile
                    {
                        Username = "User3",
                        Password = "password3"
                    }
                };
                foreach (var profile in profiles)
                {
                    context.Profiles.Add(profile);
                }
                context.SaveChanges();

                var properties = new Property[]
                {
                    new Property
                    {
                        Address = "501 & 503 S Park Square Dr, Bloomington, IN 47403",
                        NumBeds = 4,
                        NumBaths = 2,
                        IsStudio = false,
                        Sqft = 1942,
                        HomeType = "Multi-family",
                        NumParkingSpots = 4,
                        NumGarageSpots = 4,
                        AttachedGarage = true,
                        LotSize = 0.18M,
                        YearBuilt = 1993,
                        Heating = "Forced air",
                        Cooling = "Central",
                        Flooring = "Carpet, Laminate, Linoleum / Vinyl, Tile",
                        NumStories = 1,
                        HasBasement = false,
                        Gas = "Gas",
                        Sewer = "Public Sewer"
                    },
                    new Property
                    {
                        Address = "1870 E Dutcherman Dr, Bloomington, IN 47401",
                        NumBeds = 3,
                        NumBaths = 2,
                        IsStudio = false,
                        Sqft = 1800,
                        HomeType = "Single family",
                        NumParkingSpots = 2,
                        NumGarageSpots = 2,
                        AttachedGarage = true,
                        LotSize = 0.93M,
                        YearBuilt = 1977,
                        Heating = "Other",
                        Cooling = "Central",
                        Flooring = "Carpet, Laminate, Tile",
                        NumStories = 1,
                        HasBasement = false,
                        Sewer = "Septic Tank"
                    },
                    new Property
                    {
                        Address = "358 S Wilmington Ct #358, Bloomington, IN 47401",
                        NumBeds = 2,
                        NumBaths = 1,
                        IsStudio = false,
                        Sqft = 720,
                        HomeType = "Apartment",
                        YearBuilt = 1993,
                        Heating = "Forced air",
                        Cooling = "Air Conditioning",
                        Flooring = "Hardwood",
                        NumStories = 1,
                        HasBasement = false,
                        OtherDetails = "Laundry in unit"
                    }
                };
                foreach (var property in properties)
                {
                    context.Properties.Add(property);
                }
                context.SaveChanges();

                var listings = new Listing[]
                {
                    new Listing
                    {
                        ListingType = "For Sale",
                        Price = 187000,
                        ListDate = new DateTime(2020, 6, 16),
                        ProfileId = 11,
                        PropertyId = 11
                    },
                    new Listing
                    {
                        ListingType = "For Sale",
                        Price = 195000,
                        ListDate = new DateTime(2020, 5, 14),
                        ProfileId = 12,
                        PropertyId = 12
                    },
                    new Listing
                    {
                        ListingType = "Apartment for rent",
                        Price = 1100,
                        ListDate = new DateTime(2020, 3, 12),
                        ProfileId = 13,
                        PropertyId = 13
                    } 
                };
                foreach (var listing in listings)
                {
                    context.Listings.Add(listing);
                }
                
                context.SaveChanges();
            }
        }
    }
}
