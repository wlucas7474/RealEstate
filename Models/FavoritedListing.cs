using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateWebApp.Models
{
    public class FavoritedListing
    {
        public int ProfileId { get; set; }
        public Profile Profile { get; set; }

        public int ListingId { get; set; }
        public Listing Listing { get; set; }
    }
}
