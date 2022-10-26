using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;


namespace backend.Model.FuelTypeUpdates
{

    [BsonIgnoreExtraElements]
    public class FuelTypeUpdate
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;

        [BsonElement("stationID")]
        public string StationID { get; set; } = string.Empty;

    
        [BsonElement("arrivaltime")]
        public string ArrivalTime { get; set; } = string.Empty;

        [BsonElement("fuelType")]
        public string FuelType { get; set; } = string.Empty;

        [BsonElement("noOffourweel")]
        public string NoOfFourweel { get; set; } = string.Empty;

        [BsonElement("noOfsixweel")]
        public string NoOfSixweel { get; set; } = string.Empty;

        [BsonElement("noofthreeweel")]
        public string NoOfThreeweel { get; set; } = string.Empty;

        [BsonElement("nooftwoweel")]
        public string NoOfTwoweel { get; set; } = string.Empty;

        [BsonElement("petrol92")]
        public string petrol92 { get; set; } = string.Empty;

        [BsonElement("petrol95")]
        public string petrol95 { get; set; } = string.Empty;

        [BsonElement("diesel")]
        public string diesel { get; set; } = string.Empty;

        [BsonElement("superDiesel")]
        public string superDiesel { get; set; } = string.Empty;

        [BsonElement("finishtime")]
        public string FinishTime { get; set; } = string.Empty;

    }
}
