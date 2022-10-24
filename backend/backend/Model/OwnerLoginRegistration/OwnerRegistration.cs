
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace backend.Model.OwnerLoginRegistration
{

    [BsonIgnoreExtraElements]
    public class OwnerRegistration
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;

        [BsonElement("userName")]
        public string UserName { get; set; } = string.Empty;

        [BsonElement("password")]
        public string Password { get; set; } = string.Empty;

        [BsonElement("stationName")]
        public string StationName { get; set; } = string.Empty;

        [BsonElement("registerNb")]
        public string RegisterNb { get; set; } = string.Empty;

        [BsonElement("city")]
        public string City { get; set; } = string.Empty;
    }
}
