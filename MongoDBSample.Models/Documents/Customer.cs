using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDBSample.Models.Documents
{
    public sealed class Customer
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("firstName")]
        public string FirstName { get; set; } = null;

        [BsonElement("lastName")]
        public string LastName { get; set; } = null;

        [BsonElement("adress")]
        public CustomerAdress FullAdress { get; set; } = new CustomerAdress();

        [BsonElement("birthDate")]
        public DateTime BirthDate { get; set; } = new DateTime();
    }
}
