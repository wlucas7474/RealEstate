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
            using (var context = new PropertyContext(serviceProvider.GetRequiredService<DbContextOptions<PropertyContext>>()))
            {
                if (context.Property.Any())
                    return;

                context.Property.AddRange(
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
                );
                context.SaveChanges();
            }
        }
    }
}
