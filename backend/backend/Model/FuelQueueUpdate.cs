using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace backend.Model
{
    [BsonIgnoreExtraElements]
    public class FuelQueueUpdate

    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = String.Empty;

        [BsonElement("checkintime")]
        public string CheckInTime { get; set; } = String.Empty;

        [BsonElement("checkouttime")]
        public string CheckOutTime { get; set; } = String.Empty;

        [BsonElement("noofliters")]
        public string NoOfLiters { get; set; } = String.Empty;

        [BsonElement("stationId")]
        public string StationId { get; set; } = String.Empty;

        [BsonElement("vehicleType")]
        public string VehicleType { get; set; } = String.Empty;

        [BsonElement("fuelType")]
        public string FuelType { get; set; } = String.Empty;

        [BsonElement("userid")]
        public string Userid { get; set; } = String.Empty;
    }
}
