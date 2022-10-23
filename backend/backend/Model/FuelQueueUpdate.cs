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
    }
}
