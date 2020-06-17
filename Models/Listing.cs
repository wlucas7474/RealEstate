using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateWebApp.Models
{
    public class Listing
    {
        public int ListingId { get; set; }

        public string ListingType { get; set; }

        public decimal Price { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime ListDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? ClosedDate { get; set; }



        public int PropertyId { get; set; }
        public Property Property { get; set; }

        //Lister
        public int ProfileId { get; set; }
        public Profile Profile { get; set; }

        public ICollection<Photo> Photos { get; set; }

        public ICollection<FavoritedListing> ProfilesWhoFavorited { get; set; }
    }
}
