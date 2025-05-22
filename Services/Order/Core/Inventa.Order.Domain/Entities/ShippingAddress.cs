using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Inventa.Order.Domain.Entities
{
    public class ShippingAddress
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public string? FullName { get; set; }
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }
    }
}
