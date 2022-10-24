using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace backend.Model.LoginRegistration
{

    [BsonIgnoreExtraElements]
    public class UserRegistration
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;

        [BsonElement("vehicleNb")]
        public string VehicleNb { get; set; } = string.Empty;

        [BsonElement("password")]
        public string Password { get; set; } = string.Empty;

        [BsonElement("vehicleType")]
        public string VehicleType { get; set; } = string.Empty;

        [BsonElement("fuelType")]
        public string FuelType { get; set; } = string.Empty;

        [BsonElement("chesisNb")]
        public string ChesisNb { get; set; } = string.Empty;
    }
}
