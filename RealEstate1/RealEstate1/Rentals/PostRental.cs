using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace RealEstate1.Rentals
{
    public class PostRental
    {

        [BsonId]
        public string Id { get; set; }

        public string Description { get; set; }
        public int NumberOfRooms { get; set; }
        public string Address { get; set; }

        [BsonRepresentation(BsonType.Double)]
        public decimal Price { get; set; }
    }
}