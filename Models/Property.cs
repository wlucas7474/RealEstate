﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateWebApp.Models
{
    public class Property
    {
        public int PropertyId { get; set; }

        public string Address { get; set; }

        public int NumBeds { get; set; }

        public decimal NumBaths { get; set; }

        public bool IsStudio { get; set; }

        public int Sqft { get; set; }

        public string HomeType { get; set; }

        public int NumParkingSpots { get; set; }

        public int NumGarageSpots { get; set; }

        public bool AttachedGarage { get; set; }

        public decimal LotSize { get; set; }

        public int YearBuilt { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? LatestRenovationDate { get; set; }

        public string LatestRenovationDescription { get; set; }

        public string Heating { get; set; }

        public string Cooling { get; set; }

        public string Flooring { get; set; }

        public int NumStories { get; set; }

        public bool HasBasement { get; set; }

        public string Gas { get; set; }

        public string Electric { get; set; }

        public string Sewer { get; set; }

        public string Internet { get; set; }

        public string TV { get; set; }

        public string OtherDetails { get; set; }



        public ICollection<Listing> Listings { get; set; }
    }
}
