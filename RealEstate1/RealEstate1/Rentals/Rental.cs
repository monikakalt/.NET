using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace RealEstate1.Rentals
{
    
    
    public class Rental
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public int NumberOfRooms { get; set; }
        public List<string> Address =new List<string>();

        [BsonRepresentation(BsonType.Double)]
        public decimal Price { get; set; }
    }
}