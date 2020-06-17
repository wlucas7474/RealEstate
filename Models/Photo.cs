using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateWebApp.Models
{
    public class Photo
    {
        public int PhotoId { get; set; }

        public string Title { get; set; }

        public byte[] Data { get; set; }

        public string Caption { get; set; }


        public int ListingId { get; set; }
        public Listing Listing { get; set; }
    }
}
