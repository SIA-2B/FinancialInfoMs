using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Financial_ms.Models
{ 
    [BsonIgnoreExtraElements] 
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? _Id { get; set; }       

        [BsonElement("id")]
        public string? Id { get; set; }

        [BsonElement("Name")]
        public string? Name { get; set; }

        [BsonElement("Surname")]
        public string? Surname { get; set; }

        [BsonElement("Mail")]
        public string? Mail { get; set; }

        [BsonElement("Address")]
        public string? Address { get; set; }
        
        [BsonElement("PMB")]
        public Pmb? PMB {get;set;}
    }

    public class Pmb
    {
        [BsonElement("Type")]
        public string Type { get; set; } = String.Empty;

        [BsonElement("Value")]
        public string Value { get; set; } = String.Empty;

    }
}