using MongoDB.Bson.Serialization.Attributes;

namespace MongoDBSample.Models.Documents
{
    public class CustomerAdress
    {
        [BsonElement("street")]
        public string Street { get; set; } = null;

        [BsonElement("number")]
        public string Number { get; set; } = null;

        [BsonElement("city")]
        public string City { get; set; } = null;

        [BsonElement("state")]
        public string State { get; set; } = null;

        [BsonElement("country")]
        public string Country { get; set; } = null;

        [BsonElement("postalCode")]
        public string PostalCode { get; set; } = null;
    }
}
