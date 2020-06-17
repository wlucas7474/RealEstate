using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateWebApp.Models
{
    public class Profile
    {
        public int ProfileId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }


        // Created listings
        public ICollection<Listing> Listings { get; set; }

        public ICollection<FavoritedListing> FavoritedListings { get; set; }

    }
}
